using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0205_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = System.Console.ReadLine();
            int s1Number = Convert.ToInt32(s1);

            string s2 = System.Console.ReadLine();
            int s2Number = Convert.ToInt32(s2);

            string s3 = System.Console.ReadLine();

            if(s3 == "+")
            {
                int newInt = PlusTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt);
            }

            else if (s3 == "-")
            {
                int newInt = MTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt);
            }

            else if (s3 == "*")
            {
                int newInt = GTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt);
            }

            else if (s3 == "/")
            {
                int newInt = NTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt);
            }

            else if (s3 == "%")
            {
                int newInt = MKTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt);
            }
            else
            {
                System.Console.WriteLine("잘못된 기호 입니다");
            }
        }

        private static int PlusTwoParam(int number1, int number2)
        {
            int resultnumber = number1 + number2;
            return resultnumber;
        }
        private static int MTwoParam(int number1, int number2)
        {
            int resultnumber = number1 - number2;
            return resultnumber;
        }
        private static int GTwoParam(int number1, int number2)
        {
            int resultnumber = number1 * number2;
            return resultnumber;
        }
        private static int NTwoParam(int number1, int number2)
        {
            int resultnumber = number1 / number2;
            return resultnumber;
        }
        private static int MKTwoParam(int number1, int number2)
        {
            int resultnumber = number1 % number2;
            return resultnumber;
        }
    }
}
