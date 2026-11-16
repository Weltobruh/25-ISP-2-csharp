using System.Numerics;

namespace BIBLIA
{
    public class Class0001
    {
        public static long MultiMatrix(int[] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++) sum += matrix[i];
            return sum;
        }
    }

    public class Class22
    {
        public static int Alikhafaman(int[,] mas)
        {
            int max = mas[0, 0];
            int x = 0, y = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return x + y;
        }
    }
}