using Tyuiu.StoletovNA.Sprint6.Task2.V3.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task2.V3 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Столетов Никита Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < len; i++)
            {
                this.dataGridViewFunc.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                startValue++;
            }

        }

        private void dataGridViewFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
