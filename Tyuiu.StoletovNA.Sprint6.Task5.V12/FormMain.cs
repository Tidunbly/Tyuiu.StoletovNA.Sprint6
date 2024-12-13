using Tyuiu.StoletovNA.Sprint6.Task5.V12.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task5.V12 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V12.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Width = 20;
            dataGridView.Columns[1].Width = 100;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridView.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-2 Столетов Никита Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
