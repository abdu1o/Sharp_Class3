using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    public class OddNumbers
    {
        public static List<double> Generate(int size)
        {
            List<double> odd = new List<double>();

            for (int i = 1; i <= size; i += 2)
            {
                odd.Add(i);
            }

            return odd;
        }
    }
}
