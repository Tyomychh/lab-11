using ParallelMultiplicationOfMatrices;
using System;

namespace ParallelMultiplicationOfMatrices
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            Thread t1 = new Thread(() => MatrixFirst.MultiplyMatrices(matrix1, matrix2, resultMatrix, 0, matrix1.GetLength(0) / 2));
            Thread t2 = new Thread(() => MatrixFirst.MultiplyMatrices(matrix1, matrix2, resultMatrix, matrix1.GetLength(0) / 2, matrix1.GetLength(0)));

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Result matrix:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}