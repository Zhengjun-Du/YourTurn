using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace YourTurn
{
    class ExcelHandle
    {
        ArrayList studentsList = new ArrayList();

        public ArrayList ImportExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Excel文件|*.xls;*.xlsx";

            string fileName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                object missing = System.Reflection.Missing.Value;
                Excel.Application excel = new Excel.Application();
                excel.Visible = false;
                excel.UserControl = true;

                Excel.Workbook wb = excel.Application.Workbooks.Open(fileName, missing, true, missing, missing, missing,
                                   missing, missing, missing, true, missing, missing, missing, missing, missing);

                Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);

                studentsList.Clear();
                int rowIndex = 3;
                while (true)
                {
                    string stuNo = ((Excel.Range)ws.Cells[rowIndex, 2]).Text.ToString();
                    string stuName = ((Excel.Range)ws.Cells[rowIndex, 3]).Text.ToString();

                    if (stuNo != "")
                    {
                        int stuNo_int = 0;
                        try
                        {  stuNo_int = Convert.ToInt32(stuNo); }
                        catch
                        { return new ArrayList();}

                        Student stu = new Student(stuNo_int, stuName);
                        studentsList.Add(stu);
                        rowIndex++;
                    }
                    else  break;
                }
            }
            return studentsList;
        }
    }
}