using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Zmiana_nazwy_pliku
{
    public class ZmianaNazwy : IDisposable
    {
        private ProgressBar changeProgress;
        private string newDirectoryFolder;
        private bool checkingCancel = true;
        private bool disposeNotUsed = true;

        public ZmianaNazwy(ProgressBar changeProgress)
        {
            this.changeProgress = changeProgress;
        }

        public void ChangeName(string directoryChangeFile)
        {
            string[] fileNames = Directory.GetFiles(directoryChangeFile, "*.jpg"); 

            if (fileNames.Length == 0)
            {
                MessageBox.Show("Brak plików .jpg w folderze.");
                return;
            }

            newDirectoryFolder = directoryChangeFile + @"/copy";

            if (!Directory.Exists(newDirectoryFolder))
            {
                Directory.CreateDirectory(newDirectoryFolder);
            }

            changeProgress.Maximum = fileNames.Length;

            for (int i = 0; i < fileNames.Length; i++)
            {
                string nameSt = "";
                if (checkingCancel)
                {
                    nameSt = NameStart(i);
                }                          
                File.Copy(fileNames[i], newDirectoryFolder + "//P" + nameSt + i + ".jpg", true);

                changeProgress.PerformStep();
            }
            MessageBox.Show("Zmiany zostały wykonane.");
            Dispose();
        }

        private string NameStart(int i)
        {
            if(i > 1000)
            {
                checkingCancel = false;
                return "";
            }
            else if(i > 100)
            {
                return "0";
            }
            else if (i > 10)
            {
                return "00";
            }
            else 
            {
                return "000";
            }
        }

        public void Dispose()
        {
            lock(this)
            {
                if(disposeNotUsed)
                {                    
                    disposeNotUsed = false;
                    GC.Collect();
                }
            }
        }
    }
}
