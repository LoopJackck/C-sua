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

            //1. 산술 이항 연산자
            int num1 = 10;
            int num2 = 16;

            int plusResult = num1 + num2;
            int minusResult = num1 - num2;
            int multResult = num1 * num2;
            int quioResult = num1 / num2;
            int reminResult = num1 % num2;
            System.Console.WriteLine($"plusResult :{plusResult}");
            System.Console.WriteLine($"minusResult :{minusResult}");
            System.Console.WriteLine($"multResult :{multResult}");
            System.Console.WriteLine($"quioResult :{quioResult}");
            System.Console.WriteLine($"reminResult :{reminResult}");

            //2. 할당 연산자
            int num3 = 123;
            int num4 = 532;
            num4 += num3;
            System.Console.WriteLine($"plusResult :{num4}");
            num4 -= num3;
            System.Console.WriteLine($"plusResult :{num4}");

            //3. 전위형, 후위형
            int vale = 123;
            System.Console.WriteLine($"result : {++vale}");
            System.Console.WriteLine($"result : {vale++}");
            System.Console.WriteLine($"result : {vale}");
            System.Console.WriteLine($"result : {--vale}");
            System.Console.WriteLine($"result : {vale--}");
            System.Console.WriteLine($"result : {vale}");

            //4. const(상수)
            //지정된 값을 두번 다시 변경하지 못한다.
            const int thenumber = 10;
            //thenumber = 11; (X)

            //5. bool(true or false)
            bool isNameSua = true;
            bool isYourNameSua = !isNameSua;
            // isNameSuad의 반대 대입

            //6. 비교 연산자

            // ==  같다
            // !=  다르다
            // <   작다
            // >   크다
            // <=  작거나 같다
            // >=  크거나 같다

            bool isName = (3 == 3);
            System.Console.WriteLine(isName);     //true

            bool isName2 = (true == false);       
            System.Console.WriteLine(isName);     //false

            bool isName3 = ("Hello" != "Hello");
            System.Console.WriteLine(isName);     //false

            bool isName4 = (5 < 8);
            System.Console.WriteLine(isName);     //true

            bool isName5 = (5 > 8);
            System.Console.WriteLine(isName);     //false
            
            bool isName6 = (5 <= 5);
            System.Console.WriteLine(isName);     //true

            bool isName7 = (6 >= 7);
            System.Console.WriteLine(isName);     //false

            //7. 논리 연산자
            bool isTrue = true;
            bool isFalse = false;

            bool isAnd = (isTrue && isFalse);
            bool isOr = (isTrue || isFalse);

            System.Console.WriteLine(5 < 8 && 5 < 8);       //true
            System.Console.WriteLine(5 < 8 && 6 >= 7);      //false
            System.Console.WriteLine(6 >= 7 && 5 < 8);      //false
            System.Console.WriteLine(6 >= 7 && 6 >= 7);     //false

            System.Console.WriteLine(5 < 8 || 5 < 8);       //true
            System.Console.WriteLine(5 < 8 || 6 >= 7);      //true
            System.Console.WriteLine(6 >= 7 || 5 < 8);      //true
            System.Console.WriteLine(6 >= 7 || 6 >= 7);     //false

            System.Console.WriteLine(5 < 8 && 5 < 8);       //true
            System.Console.WriteLine(5 < 8 && 6 >= 7);      //false
            System.Console.WriteLine(6 >= 7 && 5 < 8);      //false
            System.Console.WriteLine(6 >= 7 && 6 >= 7);     //false

            System.Console.WriteLine(5 < 8 || 5 < 8);       //true
            System.Console.WriteLine(5 < 8 || 6 >= 7);      //true
            System.Console.WriteLine(6 >= 7 || 5 < 8);      //true
            System.Console.WriteLine(6 >= 7 || 6 >= 7);     //false

            //8. if 
            if(false)
            {
                System.Console.WriteLine("if문 true 실행");
            }

            else if (false)
            {
                System.Console.WriteLine("else if문 false 실행");
            }

            else if (false)
            {
                System.Console.WriteLine("else if문 true 실행");
            }

            else
            {
                System.Console.WriteLine("else문 실행");
            }

            int num = 3 + 2;

            if (num < 0)
            {
                System.Console.WriteLine("num은 0보다 작습니다");
            }

            else if (num < 2)
            {
                System.Console.WriteLine("num은 0보다 크고 2보다 작습니다");
            }

            else if (num < 4)
            {
                System.Console.WriteLine("num은 2보다 크고 4보다 작습니다");
            }

            else
            {
                System.Console.WriteLine("num은 4보다 큽니다");
            }

            string number1, number2;

            System.Console.WriteLine("첫번째 수를 입력해주세요 : ");
            number1 = System.Console.ReadLine();
            System.Console.WriteLine("두번째 수를 입력해주세요 : ");
            number2 = System.Console.ReadLine();

            int number11 = Convert.ToInt32(number1);
            int number22 = Convert.ToInt32(number2);

            int sum = number11 + number22;

            if (sum < 10)
            {
                System.Console.WriteLine("두 수의 합은 10보다 작습니다");
            }

            else if (sum < 20)
            {
                System.Console.WriteLine("두 수의 합은 10보다 크고 20보다 작습니다");
            }

            else if (sum < 30)
            {
                System.Console.WriteLine("두 수의 합은 20보다 크고 30보다 작습니다");
            }

            else if (sum < 40)
            {
                System.Console.WriteLine("두 수의 합은 30보다 크고 40보다 작습니다");
            }

            else
            {
                System.Console.WriteLine("num은 40보다 큽니다");
            }

            string a, b;

            System.Console.WriteLine("A를 입력해주세요 : ");
            a = System.Console.ReadLine();
            System.Console.WriteLine("B를 입력해주세요 : ");
            b = System.Console.ReadLine();

            int A = Convert.ToInt32(a);
            int B = Convert.ToInt32(b);

            if (A % 2 == 0 && B < 0)
            {
                System.Console.WriteLine("A가 짝수이고 B가 0보다 작습니다");
            }

            else if (A % 2 == 0 && B < 3)
            {
                System.Console.WriteLine("A가 짝수이고 B가 3보다 작습니다");
            }

            else if (A % 2 != 0 && B < 5)
            {
                System.Console.WriteLine("A가 홀수이고 B가 5보다 작습니다");
            }

            else
            {
                System.Console.WriteLine("조건에 만족하지 않습니다");
            }

            //9. while
            int numberLimit = 10;
            while(numberLimit > 0)
            {
                System.Console.WriteLine("Hi");
                numberLimit--;
            }

            //10. do while
            do
            {
                System.Console.WriteLine("Hi");
            } while (numberLimit > 5);

            string nnum;

            System.Console.WriteLine("입력될 숫자의 갯수 : ");
            nnum = System.Console.ReadLine();

            int nnumm = Convert.ToInt32(nnum);

            while (nnumm > 0)
            {
                System.Console.WriteLine("H");
                nnumm--;
            }

            //11. for

            //for(초기식 ; 조건식 ; 증감식)
            //{
            //}

            string nnnum;

            System.Console.WriteLine("입력될 숫자의 갯수 : ");
            nnnum = System.Console.ReadLine();
            int nnnnum = Convert.ToInt32(nnnum);

            for (int nuuu = 0 ; nuuu < nnnnum; nnnnum--)
            {
                System.Console.WriteLine("Hi");
            }

            //12. 별짓기

            for (int i = 0 ; i < 5 ; i++)
            {
                for (int row = 0 ; row < i + 1 ; row++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine("");

            }

            for (int i = 0; i < 5; i++)
            {
                for (int row = 0; row < 5 - i; row++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine("");

            }

            for (int row = 0; row < 5; row++)
            {
                for (int i = 1; i < 5 - row ; i++)
                {
                    System.Console.Write(" ");
                }
                for (int i = 0; i < row + 1; i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");

            }

            for (int row = 0; row < 5; row++)
            {
                for (int i = 1; i < row + 1 ; i++)
                {
                    System.Console.Write(" ");
                }
                for (int i = 0; i < 5 - row; i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");

            }
            // 어려운데 재밌네 집가서 5,6까지 해보자

            //13. switch(비교대상)
            int myNum = 3;

            switch(myNum)
            {
                case 0:
                    System.Console.WriteLine("0");
                    break;
                case 1:
                    System.Console.WriteLine("1");
                    break;
                case 2:
                    System.Console.WriteLine("2");
                    break;
                case 3:
                    System.Console.WriteLine("3");
                    break;
                default:
                    break;

            }

            //14. break, continue
            for (int i = 0; i<5; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("0");
                    continue;
                }

                else if(i == 1)
                {
                    Console.WriteLine("1");
                    Console.WriteLine("11");
                    continue;
                    Console.WriteLine("111");
                }

                else if (i == 2)
                {
                    Console.WriteLine("2");
                    break;
                }

                else if (i == 3)
                {
                    Console.WriteLine("3");
                }
            }
            Console.WriteLine("끝");
        }
    }
}
