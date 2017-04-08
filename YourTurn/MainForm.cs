using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTurn
{
    public partial class MainForm : Form
    {
        private Timer myTimer = new Timer();
        ArrayList studentsList = new ArrayList();
        bool studentsListValid = false;
        bool IsImportExcl = true;

        public MainForm()
        {
            myTimer.Interval = 80;
            myTimer.Tick += new EventHandler(RefreshName);
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void RefreshName(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = rd.Next() % studentsList.Count;
            if(IsImportExcl)
                this.showNmaeLabel.Text = ((Student)studentsList[i]).studentNo.ToString() + "-" + ((Student)studentsList[i]).studentName;
            else
                this.showNmaeLabel.Text = (string)studentsList[i];
        }

        private void CallRollStart(object sender, EventArgs e)
        {
            if (!studentsListValid)
                MessageBox.Show("请导入有效数据！");
            else
            {
                this.showNmaeLabel.ForeColor = Color.Black;
                myTimer.Start();
            }
        }

        private void CallRollStop(object sender, EventArgs e)
        {
            this.showNmaeLabel.ForeColor = Color.Red;
            myTimer.Stop();
        }

        private void ImportList(object sender, EventArgs e)
        {
            ExcelHandle eh = new ExcelHandle();
            studentsList = eh.ImportExcel();
            if (studentsList.Count == 0)
            {
                MessageBox.Show("数据导入失败！");
                studentsListValid = false;
                return;
            }
            else
            {
                MessageBox.Show("数据导入成功！");
                studentsListValid = true;
                IsImportExcl = true; 
            }
        }

        private void importTxtList_Click(object sender, EventArgs e)
        {
            TxtHandle th = new TxtHandle();
            IsImportExcl = false;
            studentsList = th.ImportTxt();
            if (studentsList.Count == 0)
            {
                MessageBox.Show("数据导入失败！");
                studentsListValid = false;
            }
            else
            {
                MessageBox.Show("数据导入成功！");
                studentsListValid = true;
            }
        }

        private void readMe_Click(object sender, EventArgs e)
        {
            ReadMe readme = new ReadMe();
            readme.ShowDialog();
        }
    }
}
