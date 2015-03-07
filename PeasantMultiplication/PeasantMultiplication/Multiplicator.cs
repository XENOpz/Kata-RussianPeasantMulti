namespace PeasantMultiplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Multiplicator
    {
        public int Multiply(int a, int b)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            if (a < b)
            {
                left.Add(a);
                right.Add(b);
            }
            else
            {
                right.Add(a);
                left.Add(b);
            }

            this.PeasantMethod(left, right);

            return this.AnalyzeColumnsAndCalculateResult(left, right);
        }

        private int AnalyzeColumnsAndCalculateResult(List<int> left, List<int> right)
        {
            int result = 0;

            for (int i = 0; i < left.Count; i++)
            {
                if (left[i] % 2 != 0)
                {
                    result += right[i];
                }
            }

            if (left[0] * right[0] < 0)
            {
                result *= -1;
            }

            return result;
        }

        private void PeasantMethod(List<int> left, List<int> right)
        {
            // If it's 0 or 1 we are done.
            if (Math.Abs(left.Last()) > 1) 
            { 
                left.Add(left.Last() / 2);
                right.Add(right.Last() * 2);

                this.PeasantMethod(left, right);
            }
        }
    }
}
