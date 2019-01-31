using DermaDent.Bot;
using DSoftShopcheeBot;
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

namespace DermaDent
{
    public partial class FRMBotManager : Form
    {
        DSDentAssist.RobotManager _RobotManager = new DSDentAssist.RobotManager("564766994:AAEJUk5VqNtpDc6JzbWPKumbuGK0bzktHOQ");
        SQLServerTH dbt;
        public FRMBotManager()
        {
            InitializeComponent();
            dbt = new SQLServerTH();
        }

        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            var TodayAccountWorkResult = dbt.GetTodayTransactions(TelegramID: int.Parse(textBox1.Text),fromDate:persianDateTimeBox1.Text,ToDate:persianDateTimeBox2.Text);
            FormatPrinterChargeReport fp = new FormatPrinterChargeReport();

            fp.drName = TodayAccountWorkResult[0].drName;

            fp.fromDate =persianDateTimeBox1.Text;// PersianDateTime.GetPersianDate(DateTime.Now.AddDays(-70));
            fp.ToDate = persianDateTimeBox2.Text;// PersianDateTime.GetPersianDate(DateTime.Now);
            fp.Redraw();
            fp.DrawTableContent(TodayAccountWorkResult);
            pictureBox1.Image = fp.bmp;
            if(MessageBox.Show("send?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                SendSecretPic(int.Parse(textBox1.Text), fp.bmp);
        }

        public async void SendSecretPic(int msg, Bitmap img)
        {
            ScreenCapture sc = new ScreenCapture();

            Bitmap bmp = img;
            var res = ImageToByte2(bmp);

            Stream s = new MemoryStream(res);
            Telegram.Bot.Types.InputFiles.InputOnlineFile fts = new Telegram.Bot.Types.InputFiles.InputOnlineFile(s, "invoice.jpg");
            try
            {
                await _RobotManager.Bot.SendDocumentAsync(msg, fts);
            }
            catch
            { }
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
