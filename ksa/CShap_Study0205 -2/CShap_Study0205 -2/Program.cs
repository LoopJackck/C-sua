using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0205__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 산술 이항 연산자
            int num1 = 10;
            int num2 = 16;

            int plusResult = num1 + num2;
            int minusResult = num1 - num2;
            int multResult = num1 * num2;
            int quioResult = num1 / num2;
            int reminResult = num1 % num2;
            System.Console.WriteLine($"plusResult :{plusResult}");
            System.Console.WriteLine($"plusResult :{minusResult}");
            System.Console.WriteLine($"plusResult :{multResult}");
            System.Console.WriteLine($"plusResult :{quioResult}");
            System.Console.WriteLine($"plusResult :{reminResult}");

            //1. 할당 연산자
            int num3 = 123;
            int num4 = 532;
            num4 += num3;
            System.Console.WriteLine($"plusResult :{num4}");
            num4 -= num3;
            System.Console.WriteLine($"plusResult :{num4}");

        }
    }
}
