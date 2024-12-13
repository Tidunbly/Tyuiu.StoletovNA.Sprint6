namespace Tyuiu.StoletovNA.Sprint6.Task4.V25 {
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
            buttonDone = new Button();
            buttonSave = new Button();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 53);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(238, 42);
            textBox2.TabIndex = 1;
            textBox2.Text = "Протабулировать функцию f(x) на заданном диапазоне [-5; 5]";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(301, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(131, 60);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(438, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 60);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(636, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 60);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(871, 53);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 382);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 761);
            Controls.Add(textBoxResult);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 25 | Столетов Н. А.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonInfo;
        private Button buttonDone;
        private Button buttonSave;
        private TextBox textBoxResult;
    }
}
