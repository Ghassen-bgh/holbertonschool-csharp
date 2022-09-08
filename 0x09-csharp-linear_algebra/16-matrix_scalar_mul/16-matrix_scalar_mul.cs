using System;


    class MatrixMath
    {
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] result = new double[rows, cols];
            if (rows != cols)
            {
                return (new Double[,] { { -1 } });
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
    }

