using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0129___2
{
    class Program
    {
        static void Main(string[] args)
        {
            //식당에 음식이 떡볶이, 김밥, 라면, 라뽁이가 있다
            //이중에 숫자를 입력받으면
            //입력받은 값은 비어 있게 된다.

            //최초 음식들과
            //숫자를 입력받았을때 음식을 출력하고

            //비어있게 되어있다라는 결과 값도 출력하라
            string A;
            string[] food = new string[4] { "떡볶이", "김밥", "라면", "라뽁이" };
            System.Console.WriteLine(food[0]);
            System.Console.WriteLine(food[1]);
            System.Console.WriteLine(food[2]);
            System.Console.WriteLine(food[3]);

            System.Console.WriteLine("없앨 음식은?");
            A = System.Console.ReadLine();
            int Aa = Convert.ToInt32(A);
            
            System.Console.Write("없앨 음식:");
            System.Console.WriteLine(food[Aa]);

            food[Aa] = " ";

            System.Console.WriteLine(food[0]);
            System.Console.WriteLine(food[1]);
            System.Console.WriteLine(food[2]);
            System.Console.WriteLine(food[3]);

        }
    }
}
