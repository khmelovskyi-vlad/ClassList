using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassList
{
    class Program
    {
        static void Main(string[] args)
        {
            VladList<int> vladList = new VladList<int>();
            for (int i = 0; i <= 1000; i++)
            {
                vladList.Add(i);
            }
            int j = 1000;
            while (true)
            {
                try
                {
                    Console.WriteLine(vladList[j]);
                    j--;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
