using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelMultiplicationOfMatrices
{
    public class MatrixFirst
    {
        static Semaphore semaphore = new Semaphore(1, 1);
        static object lockObject = new object();

        public static void MultiplyMatrices(int[,] matrix1, int[,] matrix2, int[,] resultMatrix, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    lock (lockObject)
                    {
                        semaphore.WaitOne();
                        resultMatrix[i, j] = sum;
                        semaphore.Release();
                    }
                }
            }
        }
    }
}
