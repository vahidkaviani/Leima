using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent.Document
{
    /*
     * this class manages file and documents with file system
     */
    class DocumentManager
    {
        string _rootPath;
        string _userName;
        string _userPath;
        public string RootPath
        {
            get
            {
                return _rootPath;
            }
            set
            {
                _rootPath = value;
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                UserPath = System.IO.Path.Combine(RootPath, _userName);
            }
        }

        public string UserPath
        {
            get
            {
                return _userPath;
            }
            set
            {
                _userPath = value;
            }
        }
        /// <summary>
        ///  for storing any document for given id create a folder by the name of user/patient/id
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="root"></param>
        public DocumentManager(string root,string username)
        {
            RootPath = root;
            UserName = username;
            CreateFolder();
        }
       
        private bool CreateFolder()
        {
            if (string.IsNullOrEmpty(RootPath))
                return false;
            if (string.IsNullOrEmpty(UserName))
                return false;
            

            if (System.IO.Directory.Exists(RootPath))
            {
                if (!System.IO.Directory.Exists(UserPath))
                    System.IO.Directory.CreateDirectory(UserPath);
            }
            else
                return false;
            return true;
        }
        public void SaveFile(string file)
        {
            string fileName = System.IO.Path.GetFileName(file);
            string destFile = System.IO.Path.Combine(UserPath, fileName);
            CopyFileAsync(file, destFile);
        }
        public void SaveFile(string []files)
        {
            string fileName = string.Empty;
            string destFile = string.Empty;
            // Copy the files to destination
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                fileName = System.IO.Path.GetFileName(s);
                destFile = System.IO.Path.Combine(UserPath, fileName);
                if (File.Exists(destFile))
                    new DialogBoxImageExist(s, destFile, fileName).ShowDialog();
                else
                    System.IO.File.Copy(s, destFile, false);
            }
        }

        public async Task CopyFileAsync(string sourcePath, string destinationPath)
        {
            using (Stream source = File.Open(sourcePath,FileMode.Open))
            {
                using (Stream destination = File.Create(destinationPath))
                {
                    await source.CopyToAsync(destination);
                }
            }
        }

        public string[] GetUserFilelist()
        {
            return System.IO.Directory.GetFiles(UserPath);
        }

    }
}
