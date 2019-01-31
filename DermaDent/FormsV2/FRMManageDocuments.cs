using DermaDent.Document;
using DermaDent.Properties;
using DSoftShopcheeBot;
using marlie.TumbnailDotnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent.FormsV2
{
    public partial class FRMManageDocuments : Form
    {
        public FRMManageDocuments()
        {
            InitializeComponent();
            SaveToFileAddress.Text = Settings.Default.PatientDocumentSavePath;
            DefaultPatientdocument();
            InitImageViewer();

            LSTVUPatientDocumentList.DragDrop += new DragEventHandler(FileDragEventArgsHandler);

            LSTVUPatientDocumentList.DragOver += new DragEventHandler(textBoxFile_DragOver);
        }

        public void FileDragEventArgsHandler(object sender, DragEventArgs e)
        {
            string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var dm = GetUserDocument(LBLIDCode.Text);

            dm.SaveFile(Files);
            DocumentList_SelectionChanged(null, null);
        }
        private void textBoxFile_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void BTNBrowse_Click(object sender, EventArgs e)
        {

            try
            {
                if (SelectSaveToFile.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetDirectoryName(SelectSaveToFile.FileName);
                    Settings.Default.PatientDocumentSavePath = path;
                    SaveToFileAddress.Text = path;
                    DermaDent.Properties.Settings.Default.Save();
                }
            }
            catch { }
        }


        private void DocumentList_SelectionChanged(object sender, EventArgs e)
        {
            if (DocumentList.SelectedRows.Count <= 0)
                return;
            var temp = GetUserDocument(DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            updatePatientDocumentList(temp.GetUserFilelist());

            LBLIDCode.Text = DocumentList.SelectedRows[0].Cells[0].Value.ToString();
            LBLPatientName.Text = (string)DocumentList.SelectedRows[0].Cells[1].Value + " " + (string)DocumentList.SelectedRows[0].Cells[2].Value;

            this.PatientImageBrowserPanel.Controls.Clear();

            m_Controller.AddFolder(temp.UserPath);
        }

        private DocumentManager GetUserDocument(string id)
        {
            string roothPath = DermaDent.Properties.Settings.Default.PatientDocumentSavePath;
            DocumentManager dm = new DocumentManager(roothPath, id);
            return dm;
        }
        public void updatePatientDocumentList(string[] files)
        {
            int i = 1;
            LSTVUPatientDocumentList.Items.Clear();
            foreach (string f in files)
            {
                string raw_filename = System.IO.Path.GetFileName(f);
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(raw_filename);
                LSTVUPatientDocumentList.Items.Add(lvi);
                i++;
            }
        }

        private ImageViewer m_ActiveImageViewer;
        public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);
        private ImageDialog m_ImageDialog;

        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }

        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender, e);
            }
        }
        public void InitImageViewer()
        {
            m_ImageDialog = new ImageDialog();

            m_AddImageDelegate = new DelegateAddImage(this.AddImage);

            m_Controller = new ThumbnailController();
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);
        }

        private ThumbnailController m_Controller;

        private int ImageSize
        {
            get
            {
                return (64 * 2);// * (this.trackBarSize.Value + 1));
            }
        }
        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;

        private void AddImage(string imageFilename)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                imageViewer.IsThumbnail = true;
                imageViewer.MouseDoubleClick += new MouseEventHandler(imageViewer_MouseClick);

                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Clear();
                cm.MenuItems.Add("حذف", new EventHandler(RemoveSelectedImage));
                //cm.MenuItems.Add("انتقال");
                //cm.MenuItems.Add("نمایش");

                imageViewer.ContextMenu = cm;
                //this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);
                this.PatientImageBrowserPanel.Controls.Add(imageViewer);
            }
        }

        private void RemoveSelectedImage(object sender, EventArgs e)
        {
            try
            {
                this.PatientImageBrowserPanel.Controls.Remove((ImageViewer)(((MenuItem)sender).GetContextMenu().SourceControl));
                File.Delete(((ImageViewer)(((MenuItem)sender).GetContextMenu().SourceControl)).ImageLocation);
            }
            catch
            {

            }
        }
        string imageLocation;
        private void imageViewer_MouseClick(object sender, MouseEventArgs e)
        {

            imageLocation = ((ImageViewer)sender).ImageLocation;
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }

            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;

            if (m_ImageDialog.IsDisposed) m_ImageDialog = new ImageDialog();
            if (!m_ImageDialog.Visible) m_ImageDialog.Show();

            m_ImageDialog.SetImage(m_ActiveImageViewer.ImageLocation);
            m_ImageDialog.FormClosed += new FormClosedEventHandler(HandleFormClose);
        }

        private void HandleFormClose(object sender, FormClosedEventArgs e)
        {

        }

        public class ThumbnailImageEventArgs : EventArgs
        {
            public ThumbnailImageEventArgs(int size)
            {
                this.Size = size;
            }

            public int Size;
        }

        private void BTNShowCashier_MouseClick(object sender, EventArgs e)
        {
            FRMCashier cashier = new FRMCashier(0);
            cashier.Show();
        }
        public void DefaultPatientQue()
        {
 
            searchPatintProfile();
        }
        public void DefaultPatientdocument()
        {
            var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    FROM [InfoSick]
                                    ORDER BY date_create ASC");
            DocumentList.DataSource = result;
        }
        private void SearchByTextDoc(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length == 0)
                DefaultPatientQue();
            if (((TextBox)sender).Text.Trim().Length < 3)
                return;
            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                return;
            if (!isNumeric)
            {
                searchPatintProfile(((TextBox)sender).Text, null);
            }
        }

        void searchPatintProfile(string LName = null, string FileID = null, DateTime? From = null, DateTime? To = null)
        {
            //if (CHKBXToday.Checked)
            //{
            //    From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            //    To = new DateTime(From.Value.Year, From.Value.Month, From.Value.Day, 23, 59, 59);
            //}
            //if (CHKBXTomorrow.Checked)
            //{
            //    To = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).AddDays(1);
            //    if (CHKBXToday.Checked)
            //        From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            //    else
            //        From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            //}
            //if (!From.HasValue)
            //    From = DateTime.Now.AddMonths(-2);
            //if (!To.HasValue)
            //    To = DateTime.Now.AddMonths(1);
            //var result = Transaction.GetOveralViewOfVisitedTime(From.Value
            //                                                        , To.Value
            //                                                       , PatientLastName: LName
            //                                                       , PatientID: FileID);
           // dataGridView1.DataSource = result;
        }

        private void TXTBXDOCFileID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfileDoc(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfileDoc(((TextBox)sender).Text, null);

            }
        }

        void searchPatintProfileDoc(string LName = null, string FileID = null)
        {
            if (!string.IsNullOrEmpty(LName))
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" +
                                        string.Format("WHERE {0} LIKE N'%{1}%'", "LNamesick", LName) +
                                    "ORDER BY date_create DESC ");
                DocumentList.DataSource = result;
            }
            else if (!string.IsNullOrEmpty(FileID))
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" + string.Format("WHERE {0} = '{1}'", "IDsick", FileID) +
                                    "ORDER BY date_create DESC "
                                            );

                DocumentList.DataSource = result;
            }
            else
                DefaultPatientdocument();
        }
    }
}
