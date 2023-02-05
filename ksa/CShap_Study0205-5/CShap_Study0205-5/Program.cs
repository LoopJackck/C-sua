using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0205_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = System.Console.ReadLine();
            int Number = Convert.ToInt32(num);
            pParam(Number);
        
        }
        private static void pParam(int number2)
        {
            for (; number2 > 0; number2--)
            {
                System.Console.WriteLine("?");
            }
        }
    }

}
