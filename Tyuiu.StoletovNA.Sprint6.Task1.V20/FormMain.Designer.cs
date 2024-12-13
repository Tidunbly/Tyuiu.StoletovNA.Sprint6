namespace Tyuiu.StoletovNA.Sprint6.Task1.V20 {
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
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonShowInfo = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(587, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.ImeMode = ImeMode.NoControl;
            textBoxResult.Location = new Point(369, 60);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(419, 313);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(446, 378);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 60);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click_1;
            // 
            // buttonShowInfo
            // 
            buttonShowInfo.Location = new Point(302, 378);
            buttonShowInfo.Name = "buttonShowInfo";
            buttonShowInfo.Size = new Size(115, 60);
            buttonShowInfo.TabIndex = 5;
            buttonShowInfo.Text = "Справка";
            buttonShowInfo.UseVisualStyleBackColor = true;
            buttonShowInfo.Click += buttonShowInfo_Click_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 415);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.Text = "-5";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 415);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "5";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 386);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(219, 23);
            textBox6.TabIndex = 8;
            textBox6.Text = "Старт шага                   Конец шага";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(buttonShowInfo);
            Controls.Add(textBoxResult);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 20 | Столетов Н. А.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonShowInfo;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
