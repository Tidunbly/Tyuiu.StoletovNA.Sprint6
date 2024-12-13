namespace Tyuiu.StoletovNA.Sprint6.Task7.V26 {
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
            buttonDone = new Button();
            buttonSaveFile = new Button();
            openFileDialog = new OpenFileDialog();
            dataGridIn = new DataGridView();
            dataGridOut = new DataGridView();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOut).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 76);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 105);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(839, 51);
            textBox2.TabIndex = 1;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 58);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Выбрать Файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(112, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(85, 58);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(232, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(75, 58);
            buttonSaveFile.TabIndex = 4;
            buttonSaveFile.Text = "Сохранить";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // dataGridIn
            // 
            dataGridIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIn.Location = new Point(31, 223);
            dataGridIn.Name = "dataGridIn";
            dataGridIn.Size = new Size(477, 424);
            dataGridIn.TabIndex = 5;
            // 
            // dataGridOut
            // 
            dataGridOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOut.Location = new Point(653, 223);
            dataGridOut.Name = "dataGridOut";
            dataGridOut.Size = new Size(481, 424);
            dataGridOut.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 692);
            Controls.Add(dataGridOut);
            Controls.Add(dataGridIn);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 26 | Столетов Н. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonSaveFile;
        private OpenFileDialog openFileDialog;
        private DataGridView dataGridIn;
        private DataGridView dataGridOut;
        private SaveFileDialog saveFileDialog;
    }
}
