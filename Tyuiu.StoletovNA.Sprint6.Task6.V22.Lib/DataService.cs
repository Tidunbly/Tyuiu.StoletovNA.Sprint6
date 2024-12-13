using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoletovNA.Sprint6.Task6.V22.Lib {
    public class DataService : ISprint6Task6V22 {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);


            string res = "";
            foreach (var line in lines)
            {
                
                string firstWord = line.Split(' ')[0];
                res += firstWord + ' ';
            }

            return res.Trim();
        }
    }
}
