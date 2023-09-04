using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbers
{
    public class FibonachiNumbers
    {
        public static List<int> Generate(int size)
        {
            List<int> fibonachi = new List<int>();

            if (size >= 1)
            {
                fibonachi.Add(0);
            }
            if (size >= 2)
            {
                fibonachi.Add(1);
            }

            while (fibonachi.Count < size)
            {
                int nextNum = fibonachi[fibonachi.Count - 1] + fibonachi[fibonachi.Count - 2];
                if (nextNum > size)
                {
                    return fibonachi;
                }

                fibonachi.Add(nextNum);
            }

            return fibonachi;
        }
    }
}
