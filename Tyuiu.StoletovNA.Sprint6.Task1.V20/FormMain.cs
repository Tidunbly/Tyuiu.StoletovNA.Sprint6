using Tyuiu.StoletovNA.Sprint6.Task1.V20.Lib;

namespace Tyuiu.StoletovNA.Sprint6.Task1.V20 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonShowInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Столетов Никита Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            int startValue = -5;
            int stopValue = 5;

            string strLine;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            textBoxResult.Text = "";
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

            for (int i = 0; i < len; i++)
            {
                strLine = String.Format("|{0,5:d}     |  {1, 5:f2}  | ", startValue, valueArray[i]);
                textBoxResult.AppendText(strLine + Environment.NewLine);
                startValue++;
            }
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
