namespace _1219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <삼항 연산자>
            int iNum1 = default;
            Console.Write("iNum1 의 값을 입력하시오. : ");
            int.TryParse(Console.ReadLine(), out iNum1); // 새로운 입력 방법
            int iNum2 = default;
            Console.Write("iNum1 의 값을 입력하시오. : ");
            int.TryParse(Console.ReadLine(), out iNum2);
            string compareNum = (iNum1 > iNum2) ? "iNum1 은 iNum2 보다 크다" : "iNum1 은 iNum2 보다 크지 않다";
            Console.WriteLine(compareNum);

            Console.Write("\n\n");
            // <문자열 연결 연산자>
            Console.Write("성을 적으세요. : ");
            string sFamilyName = Console.ReadLine();
            Console.Write("이름을 적으세요. : ");
            string sYourName = Console.ReadLine();
            string sFullName = sFamilyName + sYourName;
            Console.WriteLine("이름 : {0}", sFullName);

            Console.Write("\n\n");
            // <증감 연산자>
            int iValue = 0;
            Console.WriteLine("현재 iValue 값 : {0}", iValue);
            Console.WriteLine("전위 증가 연산 : {0}", ++iValue);
            Console.WriteLine("후위 증가 연산 : {0}", iValue++);
            Console.WriteLine("전위 감소 연산 : {0}", --iValue);
            Console.WriteLine("후위 감소 연산 : {0}", iValue--);
            Console.WriteLine("현재 iValue 값 : {0}", iValue);
            // C# 에서 증감 연산 주의점
            iValue = ++iValue;
            Console.WriteLine("현재 iValue 값 : {0}", iValue); // 이건 적용된다.
            iValue = iValue++;
            Console.WriteLine("현재 iValue 값 : {0}", iValue); // but, 이건 적용되지 않는다.
            iValue = (iValue++);
            Console.WriteLine("현재 iValue 값 : {0}", iValue); // 괄호()연산을 해도 마찬가지로 적용되지 않는다.
            // C#에서 사용해야할 방법
            iValue -= 1;
            Console.WriteLine("현재 iValue 값 : {0}", iValue);

            Console.Write("\n\n");
            // <비교 연산자 및 bool형>
            Console.Write("iCompare1의 값을 입력하시오. : ");
            int iCompare1 = default;
            int.TryParse(Console.ReadLine(), out iCompare1);
            Console.Write("iCompare2의 값을 입력하시오. : ");
            int iCompare2 = default;
            int.TryParse(Console.ReadLine(), out iCompare2);
            bool isBigger = false;
            isBigger = iCompare1 >= iCompare2;
            if (isBigger && iCompare1 == iCompare2)
            {
                Console.WriteLine("iCompare1의 값은 iCompare2의 값과 같다");
            }
            else if (isBigger)
            {
                Console.WriteLine("iCompare1의 값은 iCompare2의 값보다 크다");
            }
            else
            {
                Console.WriteLine("iCompare1의 값은 iCompare2의 값보다 작다");
            }

            Console.Write("\n\n");
            // <논리 연산자>
            bool bTF = false;
            Console.WriteLine("현재 bTF 의 상태 : {0}", bTF);
            bTF = !bTF;
            Console.WriteLine("!bTF 의 상태 : {0}", bTF);
            // &&(AND) : 비교하는 두 값이 모두 TRUE일 때 TRUE 리턴 
            Console.WriteLine("&& 계산");
            bTF = (10 > 5) && (5 > 2); // 모두 참
            Console.WriteLine("모두 참일 때, bTF 의 상태 : {0}", bTF);
            bTF = (10 > 5) && (5 < 2); // 하나라도 거짓
            Console.WriteLine("하나라도 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);
            bTF = (10 < 5) && (5 > 2); // 하나라도 거짓
            Console.WriteLine("하나라도 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);
            bTF = (10 < 5) && (5 < 2); // 모두 거짓
            Console.WriteLine("모두 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);
            // ||(AND) : 비교하는 두 값이 하나라도 TRUE일 때 TRUE 리턴 
            Console.WriteLine("|| 계산");
            bTF = (10 > 5) || (5 > 2); // 모두 참
            Console.WriteLine("모두 참일 때, bTF 의 상태 : {0}", bTF);
            bTF = (10 > 5) || (5 < 2); // 하나라도 거짓
            Console.WriteLine("하나라도 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);
            bTF = (10 < 5) || (5 > 2); // 하나라도 거짓
            Console.WriteLine("하나라도 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);
            bTF = (10 < 5) || (5 < 2); // 모두 거짓
            Console.WriteLine("모두 거짓일 때, 현재 bTF 의 상태 : {0}", bTF);

            Console.Write("\n\n");
            // <비트연산자 및 비트마스크>
            int[] arIntBit = new int[7];
            int iIntSum = default;
            for (int i = 0; i < arIntBit.Length; i++)
            {
                arIntBit[i] = 0x00000001 << i; // <시프트 연산자>
                iIntSum += arIntBit[i];
            }
            Console.Write("arIntBit 의 배열 값 : {0}", arIntBit[0]);
            for (int i = 1; i < arIntBit.Length; i++)
            {
                Console.Write(", {0}", arIntBit[i]);
            }
            Console.Write("\n");
            Console.Write("arIntBit 의 배열 총 합 : {0}", iIntSum);
            Console.Write("\n");
            int iBitResult = default;
            // |(더하기)
            iBitResult = arIntBit[0];
            Console.WriteLine("현재 iBitResult의 값 : {0}", iBitResult);
            iBitResult = arIntBit[0] | arIntBit[1];
            Console.WriteLine("현재 iBitResult의 값 : {0}", iBitResult);
            iBitResult = iBitResult | arIntBit[2];
            Console.WriteLine("현재 iBitResult의 값 : {0}", iBitResult);
            iBitResult |= arIntBit[3];
            Console.WriteLine("현재 iBitResult의 값 : {0}", iBitResult);
            for (int i = 4; i < arIntBit.Length - 1; i++)
            {
                iBitResult |= arIntBit[i];
            }
            Console.WriteLine("현재 iBitResult의 값(총 합) : {0}", iBitResult);
            // &(확인용)
            for (int i = 0; i < arIntBit.Length; i++)
            {
                int iBitCheck = iBitResult & arIntBit[i];
                if (iBitCheck > 0)
                {
                    Console.WriteLine("iBitResult 에는 arIntBit[{0}] 값이 포함되어 있으며, 포함된 arIntBit[{0}]의 값은 {1}이다.", i, arIntBit[i]);
                }
                if (iBitCheck == 0)
                {
                    Console.WriteLine("iBitResult 에는 arIntBit[{0}] 값이 포함되어 있지 않으며, 포함되지 않은 arIntBit[{0}]의 값은 {1}이다.", i, arIntBit[i]);
                }

            }
            // ^=(빼기)
            // 주의점 : 기존에 포함되지 않았던 경우에 ^=를 사용하면 추가가 되버린다.
            iBitResult ^= arIntBit[6];
            Console.WriteLine("주의를 무시하여 ^= 식으로 arIntBit[6]의 값(64)이 더해졌다.\n현재 iBitResult의 값 : {0}", iBitResult); // 주의!
            // 하지만 기존에 포함되었던 경우에 ^=를 사용하면 "빼기"가 된다.
            for (int i = 0; i < arIntBit.Length; i += 2)
            {
                iBitResult ^= arIntBit[i];
            }
            for (int i = 0; i < arIntBit.Length; i++)
            {
                int iBitCheck = iBitResult & arIntBit[i];
                if (iBitCheck > 0)
                {
                    Console.WriteLine("iBitResult 에는 arIntBit[{0}] 값이 포함되어 있으며, 포함된 arIntBit[{0}]의 값은 {1}이다.", i, arIntBit[i]);
                }
                if (iBitCheck == 0)
                {
                    Console.WriteLine("iBitResult 에는 arIntBit[{0}] 값이 포함되어 있지 않으며, 포함되지 않은 arIntBit[{0}]의 값은 {1}이다.", i, arIntBit[i]);
                }
            }
            Console.Write("iBitResult의 값은 {0}입니다.", iBitResult);

            // <랜덤함수>
            // 사용법. RANDOM 변수(객체)를 사용.
            Random rRandom = new Random();
            int iRandomNum1 = rRandom.Next(1, 7); // 1 이상 7 미만의 임의의 수를 지정.
            Console.WriteLine("iRandomNum1(rRandom.Next(1, 7))의 값 : {0}", iRandomNum1);
            int iRandomNum2 = rRandom.Next(); // 음수가 아닌 임의의 정수를 반환합니다.
            Console.WriteLine("iRandomNum2(rRandom.Next())의 값 : {0}", iRandomNum2);
            int iRandomNum3 = rRandom.Next(7); // 7 미만의 음수가 아닌 정수를 반환합니다.
            Console.WriteLine("iRandomNum3(rRandom.Next(7))의 값 : {0}", iRandomNum3);
            // 시드값에 따른 랜덤함수의 변화
            Random rRandom2 = new Random(100); // 상수 100을 입력
            int iRandomNum4 = rRandom2.Next();
            Console.WriteLine("iRandomNum2(Random rRandom2 = new Random(100))의 값 : {0}", iRandomNum4);
            int iRandomNum5 = rRandom2.Next();
            Console.WriteLine("iRandomNum2(Random rRandom2 = new Random(100))의 값 : {0}", iRandomNum5);

            // <if/else 문>
            Console.Write("1, 2, 3 중 하나를 입력하세요. : ");
            int inputNum = default;
            int.TryParse(Console.ReadLine(), out inputNum);
            if(inputNum == 1)
            {
                Console.WriteLine("입력값 : {0}", inputNum);
            }
            else if (inputNum == 2)
            {
                Console.WriteLine("입력값 : {0}", inputNum);
            }
            else if (inputNum == 3)
            {
                Console.WriteLine("입력값 : {0}", inputNum);
            }
            else
            {
                Console.WriteLine("[System] 입력값이 1, 2, 3 중 하나의 수가 아닙니다.");
            }

            // <split> : string 타입에 존재
            // 방법 1.
            Console.Write("정수 3가지를 입력하시오.(구분기호는 공백:스페이스바) : ");
            string sInputThreeNumber = Console.ReadLine();
            string[] splitString = sInputThreeNumber.Split(" "); // .Split(" ") : 구분기호가 공백(스페이스바)으로 설정된다.
            Console.WriteLine("입력하신 3가지 정수 : {0} , {1} , {2}", splitString[0], splitString[1], splitString[2]);
            int[] arIntNum = new int[splitString.Length];
            for(int i = 0; i < splitString.Length; i++)
            {
                int.TryParse(splitString[i], out arIntNum[i]);
            }
            Console.WriteLine("arIntNum[]의 값 출력 : {0} , {1} , {2}", arIntNum[0], arIntNum[1], arIntNum[2]);
            // 방법 2.
            Console.Write("정수 3가지를 입력하시오.(구분기호는 공백:스페이스바) : ");
            string[] splitString2 = 

















        }
    }
}