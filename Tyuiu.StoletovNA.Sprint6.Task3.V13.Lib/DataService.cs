using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoletovNA.Sprint6.Task3.V13.Lib {
    public class DataService : ISprint6Task3V13 {
        public int[,] Calculate(int[,] matrix)
        {


            int[] secondColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondColumn[i] = matrix[i, 1];
            }


            Array.Sort(secondColumn);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 1] = secondColumn[i];
            }
            return matrix;
        }
    }
}
