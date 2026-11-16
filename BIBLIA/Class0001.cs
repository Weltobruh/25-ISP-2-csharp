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
        public static long Alikhafaman(int[,] matrix)
        {
            int maxval = matrix[0,0];

            int maxrow = 0;
            int maxcol = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if(matrix[i,j] > maxval)
                    {
                        maxval = matrix[i,j];

                        maxrow = i;
                        maxcol = j;
                    }
                }
            }
            return maxrow + maxcol;
        }
    }
}
