using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoletovNA.Sprint6.Task2.V3.Lib {
    public class DataService : ISprint6Task2V3 {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = (Math.Sin(x))/(x + 1.2) + Math.Cos(x) * 7*x - 2;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }



            }
            return valueArray;
        }
    }
}
