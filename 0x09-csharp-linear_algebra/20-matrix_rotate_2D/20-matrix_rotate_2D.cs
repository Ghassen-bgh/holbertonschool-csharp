using System;


    class MatrixMath
    {
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            double[,] result = new double[,] {{-1}};
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (row != 2 || col != 1)
                return result;
            double[,] rotation = new double[,] {{Math.Cos(angle), -Math.Sin(angle)}, {Math.Sin(angle), Math.Cos(angle)}};
            result = Multiply(matrix, rotation);
            return result;
        }
    }

