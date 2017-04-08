namespace YourTurn
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.showNmaeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMe = new System.Windows.Forms.ToolStripMenuItem();
            this.importTxtList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "The world is wonderful because of you !";
            // 
            // showNmaeLabel
            // 
            this.showNmaeLabel.BackColor = System.Drawing.Color.White;
            this.showNmaeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showNmaeLabel.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showNmaeLabel.Location = new System.Drawing.Point(25, 135);
            this.showNmaeLabel.Name = "showNmaeLabel";
            this.showNmaeLabel.Size = new System.Drawing.Size(641, 173);
            this.showNmaeLabel.TabIndex = 2;
            this.showNmaeLabel.Text = "WATCHING HERE";
            this.showNmaeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(25, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CallRollStart);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(396, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CallRollStop);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入名单ToolStripMenuItem,
            this.importTxtList,
            this.readMe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入名单ToolStripMenuItem
            // 
            this.导入名单ToolStripMenuItem.Name = "导入名单ToolStripMenuItem";
            this.导入名单ToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.导入名单ToolStripMenuItem.Text = "ImportExcel_List";
            this.导入名单ToolStripMenuItem.Click += new System.EventHandler(this.ImportList);
            // 
            // readMe
            // 
            this.readMe.Name = "readMe";
            this.readMe.Size = new System.Drawing.Size(69, 21);
            this.readMe.Text = "ReadMe";
            this.readMe.Click += new System.EventHandler(this.readMe_Click);
            // 
            // importTxtList
            // 
            this.importTxtList.Name = "importTxtList";
            this.importTxtList.Size = new System.Drawing.Size(101, 21);
            this.importTxtList.Text = "ImportTxt_List";
            this.importTxtList.Click += new System.EventHandler(this.importTxtList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showNmaeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YourTurn--by Zhengjun-Du";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showNmaeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMe;
        private System.Windows.Forms.ToolStripMenuItem importTxtList;
    }
}

