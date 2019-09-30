using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class FileWork
    {
        FileStream fileStream;
        StreamWriter writeToFile;

        string defaultPath = @"E:\";
        string defaultFileName = "List";
        string defaultExtension = ".txt";

        string filePath;
        string fileName;
        string Extension;

        static int addToFileName = 0;

        public FileWork(string fileP, string fileN, string fileEx)
        {
            filePath = fileP;
            fileName = fileN;
            Extension = fileEx;
        }

        public FileWork()
        {
            filePath = Environment.CurrentDirectory+"\\";

            fileName = defaultFileName;
            Extension = defaultExtension;
        }
        

        public void CreateFile(string tryFileName)
        {
            string resultfileName;
            resultfileName = checkFileName(tryFileName);

            fileStream = new FileStream(resultfileName, FileMode.Create);
            writeToFile = new StreamWriter(fileStream);
        }

        public void WriteToFile(string writeString)
        {
            if (writeToFile!=null)
                writeToFile.WriteLine(writeString);
        }

        public void CloseFile()
        {
            writeToFile.Close();
            fileStream.Close();
        }

        private string checkFileName(string fileName)
        {
            while(compareFileName(fileName))
            {
                addToFileName++;
                fileName= fileName.Substring(0, fileName.Length - 1);
                fileName = fileName + addToFileName;
            }
                        
            return filePath+fileName+Extension;
        }

        private bool compareFileName(string fileName)
        {
            string[] dirs = Directory.GetFiles(filePath, "*");

            foreach (string dir in dirs)
            {
                if (dir == (filePath+fileName+Extension))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
