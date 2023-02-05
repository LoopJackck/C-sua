using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0205_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("0");
            //4장. 메소드
            int newInt1 = ShowUpNewSentence1(5);
            int newInt2 = ShowUpNewSentence2(5);
            int newInt3 = ShowUpNewSentence3(5);
            int newInt4 = ShowUpNewSentence4(5);
            int newInt5 = ShowUpNewSentence5(5);
            System.Console.WriteLine("newInt1");
            System.Console.WriteLine("newInt2");
            System.Console.WriteLine("newInt3");
            System.Console.WriteLine("newInt4");
            System.Console.WriteLine("newInt5");

            string num1;
            System.Console.WriteLine("짝수 홀수 구별할 수를 쓰시오");
            num1 = System.Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            string a =ShowUp(num2);
            System.Console.WriteLine(a);
        }

        //void -> 반환X, int -> 반환

        private static int ShowUpNewSentence1(int number)
        {
            int newnumber = number + 5 ;
            return newnumber;
        }

        private static int ShowUpNewSentence2(int number)
        {
            int newnumber2 = number * 5;
            return newnumber2;
        }

        private static int ShowUpNewSentence3(int number)
        {
            int newnumber2 = number - 5;
            return newnumber2;
        }

        private static int ShowUpNewSentence4(int number)
        {
            int newnumber2 = number / 5;
            return newnumber2;
        }

        private static int ShowUpNewSentence5(int number)
        {
            int newnumber2 = number % 5;
            return newnumber2;
        }

        private static string ShowUp(int num)
        {
            string back;
            if (num % 2 == 0)
            {
                back = ("짝수");
            }
            else
            {
                back = ("홀수");
            }
            return back;
        }

    }
}
