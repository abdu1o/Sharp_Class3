using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    public class EvenNumbers
    {
        public static List<double> Generate(int size)
        {
            List<double> even = new List<double>();

            for (int i = 0; i <= size; i += 2)
            {
                even.Add(i);
            }

            return even;
        }
    }
}
