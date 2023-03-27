using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovTechPublicLibrary
{
    public class Token
    {
        public double GetRandomNumber()
        {
            Random r = new Random();
            return r.NextDouble() * 100000;
        }
        public Tuple<int,int> SwapNumbers(Tuple<int,int> data)
        {
            int x = data.Item1;
            int y = data.Item2;
            x = x + y;
            y = x - y;
            x = x - y;
            Tuple<int, int> result = Tuple.Create<int, int>(x, y);
            return result;
        }
        public int WordCount(String data)
        {
            String[] words = data.Split(' ');
            return words.Length;
        }
    }
}
