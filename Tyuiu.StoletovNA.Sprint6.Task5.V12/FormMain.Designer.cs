namespace Tyuiu.StoletovNA.Sprint6.Task5.V12 {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            buttonOpen = new Button();
            dataGridView = new DataGridView();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(345, 77);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V12.txt. Вывести в dataGridView. Вывести все числа не кратные 5";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 29);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Условие";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(576, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(111, 55);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(439, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(122, 55);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(722, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(112, 55);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 164);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(240, 446);
            dataGridView.TabIndex = 5;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(439, 237);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(300, 300);
            chartDiag.TabIndex = 6;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 687);
            Controls.Add(chartDiag);
            Controls.Add(dataGridView);
            Controls.Add(buttonOpen);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Столетов Н. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonDone;
        private Button buttonInfo;
        private Button buttonOpen;
        private DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
