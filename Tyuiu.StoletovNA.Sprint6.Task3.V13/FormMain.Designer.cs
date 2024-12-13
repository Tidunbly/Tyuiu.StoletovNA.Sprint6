namespace Tyuiu.StoletovNA.Sprint6.Task3.V13 {
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonInfo = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 31);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 76);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(296, 56);
            textBox2.TabIndex = 1;
            textBox2.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию во втором столбце.";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(12, 360);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(128, 66);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(404, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(384, 378);
            dataGridView.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(buttonInfo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Столетов Н. А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonInfo;
        private DataGridView dataGridView;
    }
}
