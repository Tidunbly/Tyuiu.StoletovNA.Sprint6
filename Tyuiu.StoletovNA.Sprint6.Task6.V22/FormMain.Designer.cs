namespace Tyuiu.StoletovNA.Sprint6.Task6.V22 {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            buttonDone = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonInfo = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 81);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(831, 48);
            textBox2.TabIndex = 1;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(87, 63);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Выбрать файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(12, 179);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(517, 411);
            textBoxIn.TabIndex = 3;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(630, 179);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(522, 411);
            textBoxOut.TabIndex = 4;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(179, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 63);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(630, 164);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Результат";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 164);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "Входные данные";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(355, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(136, 63);
            buttonInfo.TabIndex = 8;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 621);
            Controls.Add(buttonInfo);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(buttonDone);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxIn);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonOpenFile;
        private OpenFileDialog openFileDialogTask;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Button buttonDone;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonInfo;
    }
}
