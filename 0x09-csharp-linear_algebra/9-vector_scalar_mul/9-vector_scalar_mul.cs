using System;


    class VectorMath
    {
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] result = new double[vector.Length];
            if (vector.Length == 2)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    result[i] = vector[i] * scalar;
                }
                return result;
            }
            else if (vector.Length == 3)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    result[i] = vector[i] * scalar;
                }
                return result;
            }
            else
            {
                return new double[] {-1};
            }
        }
    }

