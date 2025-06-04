using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_I_hate_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> iyiKume = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    iyiKume.Add(i);
                }
            }
            Console.WriteLine(iyiKume.Count);
            Console.Write(string.Join(", ", iyiKume));
        }
    }
}
