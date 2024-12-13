namespace Tyuiu.StoletovNA.Sprint6.Task2.V3 {
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
            buttonInfo = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonDone = new Button();
            dataGridViewFunc = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).BeginInit();
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(31, 376);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(109, 62);
            buttonInfo.TabIndex = 0;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(286, 61);
            textBox2.TabIndex = 2;
            textBox2.Text = "Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(161, 376);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 62);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewFunc
            // 
            dataGridViewFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunc.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunc.Location = new Point(438, 41);
            dataGridViewFunc.Name = "dataGridViewFunc";
            dataGridViewFunc.RowHeadersVisible = false;
            dataGridViewFunc.Size = new Size(105, 382);
            dataGridViewFunc.TabIndex = 4;
            dataGridViewFunc.CellContentClick += dataGridViewFunc_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFunc);
            Controls.Add(buttonDone);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonInfo);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 3 | Столетов Н. А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInfo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonDone;
        private DataGridView dataGridViewFunc;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
