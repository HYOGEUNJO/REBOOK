namespace _1220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //예제 1.영문 자음과 모음의 개수를 세어라(대, 소문자 모두) 

            string sConsonant = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ"; // 알파벳 자음 형태를 미리 확인
            char[] cConsonant = new char[sConsonant.Length]; // char 배열 선언. 선언한 배열 크기는 알파벳 자음 개수로 지정.
            int iConsonantLength = 0; // foreach 반복문의 카운트 설정.
            foreach (char cEachConsonant in sConsonant) // cConsonant 배열마다 각각 sConsonant 문자열의 자음 하나씩을 저장.
            {
                cConsonant[iConsonantLength] = cEachConsonant;
                iConsonantLength++;
            }

            string sVowel = "aAeEiIoOuU"; // 알파벳 모음 형태를 미리 확인
            char[] cVowel = new char[sVowel.Length]; // char 배열 선언. 선언한 배열 크기는 알파벳 모음 개수로 지정.
            int iVowelLength = 0;
            foreach (char cEachVowel in sVowel) // cVowel 배열마다 각각 sVowel 문자열의 모음 하나씩을 저장.
            {
                cVowel[iVowelLength] = cEachVowel;
                iVowelLength++;
            }

            Console.Write("영어 단어를 입력하세요. : ");
            string sInputWord = Console.ReadLine(); // 콘솔에 영단어 입력.
            char[] cInputWord = new char[sInputWord.Length]; // char 배열 선언. 선언한 배열 크기는 입력단어의 문자 개수로 지정.
            int iWordLength = 0;
            foreach (char cEachWord in sInputWord) // cInputWord 배열마다 각각 sInputWord 문자열의 문자 하나씩을 저장.
            {
                cInputWord[iWordLength] = cEachWord;
                iWordLength++;
            }

            int iConsonantCount = 0; // 결과값으로 출력할 변수 선언.
            int iVowelCount = 0; // 결과값으로 출력할 변수 선언.

            for (int i = 0; i < cInputWord.Length; ++i) // 입력한 단어를 자음 및 모음과 비교한다.
            {
                for (int i2 = 0; i2 < cConsonant.Length; ++i2) // 입력값의 자음 개수 세기.
                {
                    if (cInputWord[i] == cConsonant[i2])
                    {
                        iConsonantCount++;
                    }
                }
                for (int i2 = 0; i2 < cVowel.Length; ++i2) // 입력값의 모음 개수 세기.
                {
                    if (cInputWord[i] == cVowel[i2])
                    {
                        iVowelCount++;
                    }
                }
            }

            Console.WriteLine("결과 출력. 자음 : {0}개 , 모음 {1}개", iConsonantCount, iVowelCount); // 결과값 출력


            // 예제 2.숫자 맞추기 게임

            Random rRandom = new Random(); // 임의의 변수를 지정하기 위해 랜덤클래스 준비.

            int iAnswer = rRandom.Next(1, 101); // 정답을 1 과 100 사이의 임의의 값으로 설정.
            Console.WriteLine("< 정답 : {0} >", iAnswer); // 프로그램 확인을 쉽게하기 위해 정답을 미리 출력.

            bool bLoopCheck = true; // 반복문 유효성 체크.
            while (bLoopCheck) // true 상태에는 계속 반복.
            {
                Console.Write("정답을 입력하세요. : ");
                int iUserAnswer = default;
                int.TryParse(Console.ReadLine(), out iUserAnswer); // 입력값 설정.

                if (iUserAnswer > 100 || iUserAnswer < 1) // 예외처리.
                {
                    Console.WriteLine("[System] 유효하지 않은 입력값 입니다. 1부터 100까지의 수를 입력하세요.");
                }

                if (iAnswer == iUserAnswer) // 정답을 맞힐 경우
                {
                    Console.WriteLine("정답입니다.");
                    bLoopCheck = false; // break;
                }
                else if (iAnswer > iUserAnswer) // 입력값이 정답보다 작을 경우
                {
                    Console.WriteLine("입력값 : {0}\n정답은 입력값보다 큰 수 입니다.", iUserAnswer);
                }
                else // 입력값이 정답보다 클 경우
                {
                    Console.WriteLine("입력값 : {0}\n정답은 입력값보다 작은 수 입니다.", iUserAnswer);
                }
            }

            //예제 2 - 1.사용자가 맞추는 것이 아닌 사용자가 결정한 번호를 컴퓨터가 추측하도록 수정.사용자는 컴퓨터에게 높거나 낮은지를 알려줘야 한다. 컴퓨터가 맞출때까지 반복.

            Random rRandom2 = new Random();

            Console.Write("정답을 입력해주세요 : ");
            int iAnswer2 = default;
            int.TryParse(Console.ReadLine(), out iAnswer2); // 컴퓨터가 맞힐 정답 설정.

            int iComputerAnswerUpper = 101; // 컴퓨터의 정답 범위 최대값.
            int iComputerAnswerLower = 1; // 컴퓨터의 정답 범위 최소값.
            int iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper); // 컴퓨터의 첫번째 대답. 1 이상 101 미만의 랜덤값으로 설정. 

            bool bLoopCheck2 = true; // 반복문 유효성 체크.

            int iUserAnswer2 = default; // 컴퓨터의 대답에 대한 유저의 응답.
            string sUserAnswer = string.Empty; // 컴퓨터의 대답에 대한 유저의 응답.

            while (bLoopCheck2)
            {
                if (iAnswer2 == iComputerAnswer) // 컴퓨터가 정답을 맞힐 경우
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}\n컴퓨터가 맞추었습니다.", iComputerAnswer);
                    bLoopCheck2 = false; // break;
                }
                else
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}", iComputerAnswer); // 컴퓨터의 대답 확인.

                    Console.Write("컴퓨터에게 'up'('1') 혹은 'down'('0') 을 말씀해주세요 : ");
                    sUserAnswer = Console.ReadLine(); // 컴퓨터에게 정답 범위를 문자로 알려준다.
                    if (sUserAnswer == "1" || sUserAnswer == "0") // 컴퓨터에게 정답 범위를 정수인 1(up) 혹은 0(down) 으로 알려줄 경우.
                    {
                        int.TryParse(sUserAnswer, out iUserAnswer2);
                    }

                    // 컴퓨터의 랜덤한 대답 범위 재처리.
                    if ((sUserAnswer == "up") || (iUserAnswer2 == 1)) // 정답이 컴퓨터의 대답보다 클 경우.
                    {
                        iComputerAnswerLower = iComputerAnswer + 1;
                        iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper);
                    }
                    else if ((sUserAnswer == "down") || (iUserAnswer2 == 0)) // 정답이 컴퓨터의 대답보다 작을 경우.
                    {
                        iComputerAnswerUpper = iComputerAnswer;
                        iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper);
                    }
                }
            }

            // 예제 2-2. 예제 2-1에서 7번 이하로 컴퓨터가 맞출 수 있게 하여라.

            Random rRandom3 = new Random();

            Console.Write("정답을 입력해주세요 : ");
            int iAnswer3 = default;
            int.TryParse(Console.ReadLine(), out iAnswer3); // 정답 지정.

            int iComputerAnswerUpper2 = 101;
            int iComputerAnswerLower2 = 1;
            int iComputerAnswer2 = 100;//rRandom3.Next(iComputerAnswerLower2, iComputerAnswerUpper2); // 컴퓨터의 첫번째 대답 설정.

            bool bLoopCheck3 = true; // 유효성 체크

            int iUserAnswer3 = default; // 컴퓨터의 대답에 대한 유저의 응답.
            string sUserAnswer2 = string.Empty; // 컴퓨터의 대답에 대한 유저의 응답.

            int iComputerAnswerLoopCount = 0; // 컴퓨터가 대답한 횟수 확인.

            while (bLoopCheck3)
            {
                if (iAnswer3 == iComputerAnswer2)
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}, 루프 횟수 : {1}(첫 대답을 포함한 대답 총 횟수 : {2})\n컴퓨터가 맞추었습니다.",
                        iComputerAnswer2, iComputerAnswerLoopCount, iComputerAnswerLoopCount + 1);
                    bLoopCheck3 = false; // break;
                }
                else
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}, 루프 횟수 : {1}(첫 대답을 포함한 대답 총 횟수 : {2})",
                        iComputerAnswer2, iComputerAnswerLoopCount, iComputerAnswerLoopCount + 1);

                    Console.Write("컴퓨터에게 'up'('1') 혹은 'down'('0') 을 말씀해주세요 : ");
                    sUserAnswer2 = Console.ReadLine(); // 컴퓨터에게 정답 범위를 문자로 알려준다.
                    if (sUserAnswer2 == "1" || sUserAnswer2 == "0") // 컴퓨터에게 정답 범위를 정수인 1(up) 혹은 0(down) 으로 알려줄 경우.
                    {
                        int.TryParse(sUserAnswer2, out iUserAnswer3);
                    }

                    if ((sUserAnswer2 == "up") || (iUserAnswer3 == 1)) // UP
                    {
                        iComputerAnswerLower2 = iComputerAnswer2;
                    }
                    else if ((sUserAnswer2 == "down") || (iUserAnswer3 == 0)) // DOWN
                    {
                        iComputerAnswerUpper2 = iComputerAnswer2;
                    }

                    iComputerAnswer2 = (iComputerAnswerUpper2 + iComputerAnswerLower2) / 2; // 컴퓨터의 대답을 재설정.
                    // 중간값 탐색 알고리즘으로, 1 이상 100 이하의 숫자는 7번의 Reply(첫 대답을 포함하여 총 8번의 대답)로 숫자를 찾을수 있다.
                    //  100  /   2   =   50    loop : 1
                    //  50   /   2   =   25    loop : 2
                    //  25   /   2   =   12    loop : 3
                    //  12   /   2   =   6     loop : 4
                    //  6    /   2   =   3     loop : 5
                    //  3    /   2   =   1     loop : 6
                    //  1    /   2   =   0     loop : 7
                    iComputerAnswerLoopCount++; // 루프카운트 증가.
                }
            }

            // 예제 3. 산수 문제 자동 출제.
            // 덧셈, 뺼셈, 곱셈, 나눗셈 문제를 자동으로 생성. 피연산자는 0 ~ 99 사이의 숫자(난수) 한 번이라도 맞으면 종료. 틀리면 리트라이(기본형)

            Random rRandom4 = new Random();

            bool bMathProblem = true; // 인트로 시퀀스 유효성 체크. 이것이 참인 상태여야 가장 포괄적인 프로그램이 실행된다.
            bool bMathCheck = true; // 문제를 만들때 유효성 체크. 문제의 조건 체크. 모든 정답은 100 이하로 설정된다. 
            bool bStart = true; // 정답 입력 유효성 체크. 같은 문제에 대한 정답을 계속 적을 수 있도록 설정.

            while (bMathProblem) // 인트로 시퀀스 
            {
                Console.Write("무슨 문제(더하기, 빼기, 곱하기, 나누기) 풀래? : ");
                string sUserProblemChoice = Console.ReadLine(); // 문제 타입 분기점.

                string sAddition = "더하기";
                string sSubtraction = "빼기";
                string sMultiply = "곱하기";
                string sDivide = "나누기";

                int sNumber1, sNumber2; // 문제의 인수 설정.

                if (sUserProblemChoice == sAddition) // 더하기 문제.
                {
                    sNumber2 = default; // 인수 초기화.
                    sNumber1 = default;

                    while (bMathCheck) // 문제의 유효성 체크.
                    {
                        sNumber1 = rRandom4.Next(1, 100);
                        sNumber2 = rRandom4.Next(1, 100);
                        if (sNumber1 + sNumber2 < 100) // 정답을 0 ~ 99 사이의 난수로 설정하라.
                        {
                            bMathCheck = false;
                        }
                    }

                    while (bStart) // 문제의 유효성이 적절하다면, 문제 풀이가 시작된다.
                    {
                        Console.Write("{0} + {1} = 정답 : ", sNumber1, sNumber2); // 문제 안내.

                        int iUserAnswer = default;
                        int.TryParse(Console.ReadLine(), out iUserAnswer); // 정답 입력.

                        if (iUserAnswer == (sNumber1 + sNumber2)) // 정답일 경우.
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else // 오답일 경우.
                        {
                            Console.WriteLine("Retry");
                        }
                    }
                }

                else if (sUserProblemChoice == sSubtraction) // 빼기 문제.
                {
                    sNumber2 = default; // 인수 초기화.
                    sNumber1 = default;

                    while (bMathCheck) // 문제의 유효성 체크.
                    {
                        sNumber1 = rRandom4.Next(1, 100);
                        sNumber2 = rRandom4.Next(1, 100);
                        if (sNumber1 > sNumber2) // 정답을 0 ~ 99 사이의 난수로 설정하라.
                            bMathCheck = false;
                    }

                    while (bStart) // 문제의 유효성이 적절하다면, 문제 풀이가 시작된다.
                    {
                        Console.Write("{0} - {1} = 정답 : ", sNumber1, sNumber2); // 문제 안내.

                        int iUserAnswer = default;
                        int.TryParse(Console.ReadLine(), out iUserAnswer); // 정답 입력.

                        if (iUserAnswer == (sNumber1 - sNumber2)) // 정답일 경우.
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else // 오답일 경우
                        {
                            Console.WriteLine("Retry");
                        }
                    }
                }

                else if (sUserProblemChoice == sMultiply) // 곱하기 문제.
                {
                    sNumber2 = default; // 인수 초기화.
                    sNumber1 = default;

                    while (bMathCheck) // 문제의 유효성 체크.
                    {
                        sNumber1 = rRandom4.Next(1, 100);
                        sNumber2 = rRandom4.Next(1, 100);
                        if (sNumber1 * sNumber2 < 100) // 정답을 0 ~ 99 사이의 난수로 설정하라.
                            bMathCheck = false;
                    }

                    while (bStart) // 문제의 유효성이 적절하다면, 문제 풀이가 시작된다.
                    {
                        Console.Write("{0} * {1} = 정답 : ", sNumber1, sNumber2); // 문제 안내.

                        int iUserAnswer = default;
                        int.TryParse(Console.ReadLine(), out iUserAnswer); // 정답 입력.

                        if (iUserAnswer == (sNumber1 * sNumber2)) // 정답일 경우.
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else // 오답일 경우
                        {
                            Console.WriteLine("Retry");
                        }
                    }
                }

                else if (sUserProblemChoice == sDivide) // 나누기 문제.
                {
                    sNumber1 = default; // 인수 초기화.
                    sNumber2 = default;

                    while (bMathCheck) // 문제의 유효성 체크.
                    {
                        sNumber1 = rRandom4.Next(1, 100);
                        sNumber2 = rRandom4.Next(1, 100); // 정답을 0 ~ 99 사이의 난수로 설정하라.
                        bMathCheck = false;
                    }

                    while (bStart) // 문제의 유효성이 적절하다면, 문제 풀이가 시작된다.
                    {
                        Console.Write("{0} / {1} = 정답(소수점 두번째 자리까지 반올림하시오.) : ", sNumber1, sNumber2); // 문제 안내.

                        double dUserAnswer = default;
                        double.TryParse(Console.ReadLine(), out dUserAnswer); // 정답 입력.

                        if (dUserAnswer == Math.Round((double)sNumber1 / (double)sNumber2, 2)) // 소수점 2자리까지 반올림 처리한다. 정답일 경우.
                        {
                            Console.WriteLine("정답입니다."); 
                            bStart = false;
                        }
                        else  // 오답일 경우
                        {
                            Console.WriteLine("Retry");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                    continue; // 이게 있어야 인트로 시퀀스로 다시 돌아갈 수 있다.
                }
                bMathProblem = false; // break;
            }








































        }
    }
}