using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0201
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName;
            string birthYear;
            String myjen;
            String myzip;
            String my;

            System.Console.WriteLine("이름을 입력해주세요 : ");
            myName = System.Console.ReadLine();

            System.Console.WriteLine("태어난 연도를 입력해주세요");
            birthYear = System.Console.ReadLine();

            System.Console.WriteLine("주소를 입력해주세요 : ");
            myzip = System.Console.ReadLine();

            System.Console.WriteLine("성별을 입력해주세요 : ");
            myjen = System.Console.ReadLine();

            System.Console.WriteLine("자기 소개를 입력해 주세요 : ");
            my = System.Console.ReadLine();

            int myAgeNumber = Convert.ToInt32(birthYear);
            myAgeNumber = 2023 - myAgeNumber + 1;


            System.Console.Write("당신의 이름은 ");
            System.Console.Write(myName);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 나이는 ");
            System.Console.Write(myAgeNumber);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 주소는 ");
            System.Console.Write(myzip);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 성별은 ");
            System.Console.Write(myjen);
            System.Console.WriteLine("입니다");

            System.Console.WriteLine(my);
        }
    }
}
