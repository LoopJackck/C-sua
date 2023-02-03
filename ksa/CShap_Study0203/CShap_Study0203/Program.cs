using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0203
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            string[] food;
            food = new string[4] { "떡볶이", "김밥", "만두", "튀김" };
            System.Console.WriteLine(food[0]);
            System.Console.WriteLine(food[1]);
            System.Console.WriteLine(food[2]);
            System.Console.WriteLine(food[3]);
            System.Console.WriteLine("먹을 음식은?");
            A = System.Console.ReadLine();
            int Aa = Convert.ToInt32(A);

            System.Console.Write(food[Aa]);
            System.Console.WriteLine("을(를) 먹었다");

            food[Aa] = " ";

            System.Console.WriteLine(food[0]);
            System.Console.WriteLine(food[1]);
            System.Console.WriteLine(food[2]);
            System.Console.WriteLine(food[3]);
        }
    }
}
