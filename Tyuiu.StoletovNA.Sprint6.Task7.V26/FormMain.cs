using System.IO;
using Tyuiu.StoletovNA.Sprint6.Task7.V26.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task7.V26 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;

            string fileData = File.ReadAllText(openFilePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows1 = lines.Length;
            int cols1 = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows1, cols1];

            for (int r = 0; r < rows1; r++)
            {
                string[] line_r = lines[r].Split(';');

                for (int c = 0; c < cols1; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            rows = arrayValues.GetLength(0);
            cols = arrayValues.GetLength(1);

            dataGridIn.ColumnCount = cols;
            dataGridIn.RowCount = rows;
            dataGridOut.ColumnCount = cols;
            dataGridOut.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridIn.Columns[i].Width = 25;
                dataGridOut.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        { 

            int[,] arrayValues = ds.GetMatrix(openFilePath);

            // Обновите массив arrayValues с изменениями
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // Передаем значения обратно в dataGridOut после изменения
                    dataGridOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutFileTask7.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridOut.RowCount;
            int cols = dataGridOut.ColumnCount;

            string str = "";

            for (int i = 0;  i < rows; i++)
            {
                for (int j = 0;  j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
