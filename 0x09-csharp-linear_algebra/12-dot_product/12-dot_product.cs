using System;


    class VectorMath
    {
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            double dotProduct = 0;
            if (vector1.Length == vector2.Length && vector1.Length <= 3 && vector1.Length >= 2)
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    dotProduct += vector1[i] * vector2[i];
                }
                return dotProduct;
            }
            return -1;
        }
    }

