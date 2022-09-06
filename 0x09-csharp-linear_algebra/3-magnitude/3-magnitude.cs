using System;


    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            double sum = 0;
            if (vector.Length == 2)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    sum += Math.Pow(vector[i], 2);
                }
                return Math.Round(Math.Sqrt(sum), 2);
            }
            else if (vector.Length == 3)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    sum += Math.Pow(vector[i], 2);
                }
                return Math.Round(Math.Sqrt(sum), 2);
            }
            else
            {
                return -1;
            }
        }
    }

