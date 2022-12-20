namespace _1216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <출력>
            Console.Write("Console.Write : 줄바꿈 없음");
            Console.Write("\n"); // = Console.WriteLine();
            Console.WriteLine("Console.WriteLine : 줄바꿈 있음");


            Console.Write("\n\n");
            // <문자열 보간법 $"{}">
            Console.WriteLine($"Hello" + " " + "world");

            Console.WriteLine("{0} {1}", "hello", "world"); // * {0}, {1} 이라고 지정된 공간에 각각 "hello", "world"가 삽입된다.
            // * 추가 설명
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 3);

            string hello = "hello";
            string world = "world";
            Console.WriteLine($"{hello} {world}"); // * 선언한 변수로 출력하는 법
            // * 추가 설명
            // $"" 보간법을 사용하여 문자열 출력, {}안에 선언된 변수가 출력되며, ""안에 있는 다른 문자열도 출력이 된다.
            Console.WriteLine($"{hello} 가나다라 {world}");

            string hello_world = string.Format("{0} {1}", hello, world);
            Console.WriteLine(hello_world);

            hello_world = hello + " " + world;
            Console.WriteLine(hello_world); // + 를 사용하여 느려지는 연산 방법


            // <상수화>
            const int iData = 10; // 상수인 변수는 선언과 동시에 정의되어야 한다. 이를 초기화라고 한다. (선언 + 정의 = 초기화)
            //iData = 20; - 에러 : 상수화된 후에는 재정의 할 수 없다.
            //int nData;        - 선언
            //nData = 100;      - 정의
            //int nData = 100;  - 초기화


            // <데이터 형식> : 자료형 타입
            // https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            // <null 키워드>
            // 숫자형식은 변수선언시 물음표기호('?')를 붙이면 null 가능 형식으로 변경된다.
            int? ex1 = null;
            //int ex1 = null - 에러 발생
            // 문자형식은 물음표기호가 따로 필요없으며, "string.empty"로 정의하는 것이 정석이다.
            string ex2 = null;
            string ex3 = string.Empty;


            // <자동타입추론> : var 형식
            var autoInt = 10; // 자동추론으로 autoVariable는 int 형식으로 자동으로 바뀐다.
            var autoFloat = 10.0f;
            var autoDouble = 10.0;
            var autoString = "hello";
            var autoChar = 'A';


            Console.Write("\n\n");
            // <열거형> **
            ENUM enumNumber = ENUM.TWO;
            Console.WriteLine(enumNumber); // 출력시에 "TWO"라고 출력된다.


            Console.Write("\n\n");
            // <입력>
            // Console.ReadLine() : 문자열을 입력받는다.
            Console.Write("Console.ReadLine() : ");
            string sInput = Console.ReadLine();
            Console.WriteLine(sInput);

            //// Console.Read() : 입력한 하나의 문자(문자열이 아닌 하나의 문자 혹은 숫자)를 유니코드 값으로 변환하여 출력. (ex.'a' = 97로 확인된다. 정수를 입력할 경우 입력값과 다른 수로 확인된다.) * 그냥 쓰지말자 - Read() 는 입력후 바로 터미널이 끝난다.
            //Console.Write("Console.Read() : ");
            //int sInput2 = Console.Read(); // 입력 : int 타입
            //Console.WriteLine(sInput2); // 해당 문자의 유니코드 값 반환
            //Console.WriteLine(Convert.ToChar(sInput2)); // 입력한 문자(숫자가 아닌)를 유니코드 값이 아닌 문자로 재반환하여 출력하고 싶을 경우

            //// Console.ReadKey() : 사용자가 누른 문자나 기능 키를 가져온다.
            //Console.Write("Console.ReadKey() : ");
            //ConsoleKeyInfo sInput3 = Console.ReadKey(false); // 입력 : ConsoleKeyInfo 타입 , true : 입력즉시 입력값 미표시 / false : 표시
            //Console.Write("\n");
            //Console.Write(sInput3.KeyChar);


            Console.Write("\n\n");
            // <형식 변환(Casting)>
            Console.Write("정수를 입력하세요 : ");
            string sData = Console.ReadLine(); // 입력 타입이 문자열(string)이다.
            Console.WriteLine("{0}(입력 값) + 10 = {1} 입니다", sData, sData + 10); // 입력 타입이 string이기 때문에 숫자로 인식이 된 것이 아니라 문자열로 인식되어 "수의 더하기"가 아닌 "문자열 이어붙이기"로 계산된다. 
            int iChangeInt = Convert.ToInt32(sData);
            Console.WriteLine("{0}(입력 값) + 10 = {1} 입니다", iChangeInt, iChangeInt + 10); // int 타입으로 형변환 1.
            int iChangeInt2 = int.Parse(sData);
            Console.WriteLine("{0}(입력 값) + 10 = {1} 입니다", iChangeInt2, iChangeInt2 + 10); // int 타입으로 형변환 2.
            int iChangeInt3; // ( = default;)
            int.TryParse(sData, out iChangeInt3);
            Console.WriteLine("{0}(입력 값) + 10 = {1} 입니다", iChangeInt3, iChangeInt3 + 10); // int 타입으로 형변환 3. 가장 추천하는 방법.

        }

        enum ENUM //**
        {
            ZERO, // 커서를 올리면 "숫자"로 표시됨
            ONE, 
            TWO,
            THREE
        };
    }
}