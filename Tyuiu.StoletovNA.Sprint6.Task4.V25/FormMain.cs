using Tyuiu.StoletovNA.Sprint6.Task4.V25.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task4.V25 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask4V25.txt");
            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(fullPath);
            }

            double[] valueArray = ds.GetMassFunction(-5, 5);
            foreach (double value in valueArray)
            {
                File.AppendAllText(fullPath, value.ToString() + Environment.NewLine);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            double[] valueArray = ds.GetMassFunction(-5, 5);

            foreach (double value in valueArray)
            {
                textBoxResult.AppendText(value.ToString() + Environment.NewLine);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-24-2 Столетов Никита Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
