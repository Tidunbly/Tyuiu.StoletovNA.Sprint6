using Tyuiu.StoletovNA.Sprint6.Task3.V13.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task3.V13 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -7, 34, -2, 25, 5},
                                      { -16, -12, 30, -3, 17},
                                      { 3, -15, 12, 5, -5},
                                      { 17, 22, -3, 32, -11},
                                      { 9, 28, 1, -9, -2} };
        

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Столетов Никита Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void FormMain_Load(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);
            int rows = 5;
            int cols = 5;

            dataGridView.ColumnCount = cols;
            dataGridView.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
