using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int graine = DateTime.Now.Millisecond;
            Random rnd = new Random(graine);
            Console.WriteLine(rnd.Next(1, 10).ToString());
            for (int i = 0; i <15; i++)
            {
                Console.Write(DateTime.Now.Millisecond);

            }
            Console.ReadKey();
        }
    }
}
