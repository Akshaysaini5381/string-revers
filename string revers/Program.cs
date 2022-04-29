using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_revers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int length = str.Length - 1;

            for (int i = length; i >=0; i--)
            {
                Console.Write(str[i]);
            }

            Console.ReadLine();

        }
    }
}
