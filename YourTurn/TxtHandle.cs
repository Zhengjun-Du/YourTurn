using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTurn
{
    class TxtHandle
    {
        ArrayList studentsList = new ArrayList();
        public ArrayList ImportTxt()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Txt文件|*.txt";

            string fileName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] strs = line.Split(new Char[] { ' ','\t' });
                    string mergestr = strs[0] + "-" + strs[1];
                    studentsList.Add(mergestr);
                }
            }

            return studentsList;
        }
    }
}
