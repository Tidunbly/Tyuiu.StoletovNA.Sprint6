using Tyuiu.StoletovNA.Sprint6.Task0.V30.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task0.V30 {
    public partial class Form1 : Form {
        public Form1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            string str = Convert.ToString(res);
            InitializeComponent();
            textBox1.Text = str;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
