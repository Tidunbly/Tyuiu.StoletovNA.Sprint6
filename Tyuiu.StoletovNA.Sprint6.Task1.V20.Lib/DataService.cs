using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.StoletovNA.Sprint6.Task1.V20.Lib {
    public class DataService : ISprint6Task1V20 {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) - 2 * x) == 0)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = (2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x);
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
                
                
                
            }
            return valueArray;
        }
        
    }
}
