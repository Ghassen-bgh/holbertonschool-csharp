using System;


    class MatrixMath
    {
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {

            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);
            /*if (matrix1.Length != matrix2.Length || rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
                return result;
            result = new double[rows, cols];*/
            if (matrix1.Length != matrix2.Length ||
                rows1 != cols1 ||
                rows2 != cols2)
            {
                return (new Double[,] { { -1 } });
            }

        double[,] result = new double[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
    }

