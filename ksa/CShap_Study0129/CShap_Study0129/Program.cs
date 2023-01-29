using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap_Study0129
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1장

            // 1. Write 쓰기

            System.Console.Write("Hello World");

            System.Console.WriteLine("내 이름은 김수아 입니다");
            System.Console.WriteLine("나는 이제 고3이 되었습니다");
            System.Console.WriteLine("나는 생각보다 이 수업이 많이 즐겁고 기대가 됩니다");

            // 2. WriteLine 쓰기

            System.Console.WriteLine("WriteLine 신기해요");

            // 3. 10줄이지만 5줄만 보이게 하기!

            System.Console.WriteLine("1");
            System.Console.Write("2");
            System.Console.WriteLine("3");
            System.Console.Write("4");
            System.Console.WriteLine("5");
            System.Console.Write("6");
            System.Console.WriteLine("7");
            System.Console.Write("8");
            System.Console.WriteLine("9");
            System.Console.Write("10\n");

            // 4. //를 쓰면 주석!


            // 5. 데이터형 - String

            String myName;

            myName = "kimsua";

            System.Console.WriteLine(myName);


            String myBirth;

            myBirth = "1120";

            System.Console.WriteLine(myBirth);


            String myHOME;

            myHOME = "...";

            System.Console.WriteLine(myHOME);

            String myJoin;

            myJoin = "drawing";

            System.Console.WriteLine(myJoin);


            String myDream;

            myDream = "Having three cat";

            System.Console.WriteLine(myDream);

            // 6. ReadLine();

            String myName2;
            String myjen;
            String myold;
            String myzip;

            System.Console.WriteLine("이름을 입력해주세요 : ");
            myName2 = System.Console.ReadLine();

            System.Console.WriteLine("성별을 입력해주세요 : ");
            myjen = System.Console.ReadLine();

            System.Console.WriteLine("나이를 입력해주세요 : ");
            myold = System.Console.ReadLine();

            System.Console.WriteLine("주소를 입력해주세요 : ");
            myzip = System.Console.ReadLine();

            System.Console.Write("당신의 이름은 ");
            System.Console.Write(myName2);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 성별은 ");
            System.Console.Write(myjen);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 나이는 ");
            System.Console.Write(myold);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 주소는 ");
            System.Console.Write(myzip);
            System.Console.WriteLine("입니다");

            System.Console.WriteLine($"당신의 이름은 {myName2} 이고, 당신의 나이는 {myold} 입니다");
            System.Console.WriteLine("당신의 이름은 {0} 이고, 당신의 나이는 {1} 입니다", myName2, myold);

            //// 2장

            // 1. char int float

            int i = 0;

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            // 2. 이스퀘이프 코드

            // 3. String

            string ksa1 = "ksa";
            System.Console.WriteLine(ksa1);
            string kdh2 = "kdh";
            string sum = ksa1 + kdh2;
            System.Console.WriteLine(sum);

            // 4. null

            // 5. 캐스팅 -> 형식바꾸기

            string birthYear;
            System.Console.WriteLine("태어난 연도를 입력해주세요");
            birthYear = System.Console.ReadLine();

            int myAgeNumber = Convert.ToInt32(birthYear);

            //쓰다 말았다..

            // 6. @
            System.Console.WriteLine(@"a
aaaaa
aaa
aaaa");

            // 과제1. 변수형 종류를 주석 으로 작성후, 각 변수형들의 최대 값 최소값 출력하기
            //변수형의 종류
            //1. char - 문자형
            //2. int - 정수형
            //3. float - 실수형
            //4. string - 문장쓸 떄 사용
            //5. double, long 등등
            System.Console.WriteLine(char.MaxValue);
            System.Console.WriteLine(char.MinValue);

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(float.MinValue);

            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(double.MinValue);

            System.Console.WriteLine(long.MaxValue);
            System.Console.WriteLine(long.MinValue);


            // 과제2. string으로 이름, 나이 입력 받고, 출력하기
            // 나이는 출생년도만 입력받기
            String myName3;
            string birthYear2;

            System.Console.WriteLine("이름을 입력해주세요 : ");
            myName3 = System.Console.ReadLine();

            System.Console.WriteLine("태어난 연도를 입력해주세요");
            birthYear2 = System.Console.ReadLine();

            int myAgeNumber2 = Convert.ToInt32(birthYear2);
            myAgeNumber2 = 2023 - myAgeNumber2 + 1;


            System.Console.Write("당신의 이름은 ");
            System.Console.Write(myName2);
            System.Console.WriteLine("입니다");

            System.Console.Write("당신의 나이는 ");
            System.Console.Write(myAgeNumber2);
            System.Console.WriteLine("입니다");

            // 과제3. @사용해서 별그리기
            System.Console.WriteLine(@"         @
        @@@
       @@@@@
 @@@@@@@@@@@@@@@@@
     @@@@@@@@@
   @@@@@  @@@@@
  @@          @@");

            // 과제4. int값을 float 로 캐스팅하기
            //        3.12 를 int값으로 캐스팅하기
            int num = 3;
            float flNum = (float)num;
            float flNum2 = 3.12f;
            int num3 = Convert.ToInt32(flNum2);
            //int num3 = (int)flNum2;
            System.Console.WriteLine(num3);

            //이름을 입력받는다.
            //입력받은 이름의 길이를 숫자로 바꾸고
            //받은숫자를 출력한다.
            String myName4;

            System.Console.WriteLine("이름을 입력해주세요 : ");
            myName4 = System.Console.ReadLine();

            string str = "가나다라마바사";
            int length = str.Length;
            System.Console.WriteLine(length);

            ////3장

            //값을 가져올껀데 int, string, char 형인지 모를 때 -> var

            // 1. 배열

            int[] iii = new int[3];

            int[] kkk = new int[4] { 4, 6, 1, 4 };
            System.Console.WriteLine(kkk[0]);

            string[] lang = new string[3] { "C#", "C++", "C" };
            long[] olo = new long[1] { 2 };

            //kkk b-> 89, 6, 456, 4
            //lang -> C#, C++, C

            //int형 배열 5칸짜리 5개
            //string 형 배열 5칸짜리 5개 만들기

            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = new int[5] { 4, 6, 2, 4, 9 };
            int[] c = new int[5] { 4, 1, 1, 3, 5 };
            int[] d = new int[5] { 4, 5, 1, 4, 7 };
            int[] e = new int[5] { 4, 6, 3, 1, 5 };

            string[] langg = new string[5] { "C#", "C++", "C", "python", "Java"};
            string[] langgg = new string[5] { "C", "a", "t", "s", "W" };
            string[] langggg = new string[5] { "D", "o", "g", "S", "M" };
            string[] langgggg = new string[5] { "C#", "C++", "C", "python", "eJ" };
            string[] langggggg = new string[5] { "C#", "C++", "C", "python", "Java" };

            // 2. 크기 나중에 수정하기 

            int[] LaterArray;

            System.Console.WriteLine("배열의 크키는?");
            string ArraySize;
            ArraySize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(ArraySize)];

            // 3. 또다른 예제

            string[] _lang = new string[3];
            _lang[0] = "C";
            _lang[0] = "C++";
            _lang[0] = "C#";
            //...

        }
    }
}
