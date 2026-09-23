namespace _0923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 생성
            //동일한 자료형의 연속된 메모리 공간
            //힙에 생성 --> 힙 동적 메모리 공간
            //힙에 개체를 생성하는데 new

            //배열의 선언
            ////자료형[]
            //int[] intArray = new int[] { 52, 273, 32 };
            //int[] intArray2;
            //intArray2 = new int[] { 52, 273 };
            //int[] intArray3 = { };

            ////요소(element)를 출력합니다
            //var i = 0;
            //while ( i < intArray2.Length )
            //{
            //    Console.WriteLine(intArray2[i]);
            //    ++i;
            //}

            //Length 배열의 길이
            //var i = 0;
            //while (i < intArray2.Length) {
            //    Console.Write($"{i}");
            //    Console.Write(intArray2[i]);


            //1~100 더하기
            //var sum = 0;
            //for (var i = 1; i < 100; ++i)
            //    sum += i;
            //Console.WriteLine($"{sum}");


            //var pactorial = 1UL;
            //  for (var i = 1UL; i <= 30; ++i)
            //    {
            //        pactorial *= i;
            //        Console.WriteLine($"{i} : {pactorial}");
            //    }


            //if (false)
            //{

            //    for (var c = '가'; c <= '힣'; ++c)
            //    {
            //        Console.Write((char)c);
            //    }
            //}
            //if (true)
            //{
            //    var start = DateTime.Now.Ticks;
            //    var count = 0;


            //    while (start + (10000000) > DateTime.Now.Ticks)
            //    {
            //        count++;
            //    }

            //    Console.WriteLine(count + "만큼 반복했습니다.");
            //}
            //별 삼각형 만들기 반짤린
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }

            //루프문
            //for
            //while
            //do while
            
            //break, continue

            //문자열
            //ToUpper, To
            요소,대괄호,Length,break,continue,1
            2
            3
            3
            2
            2
            3
            2
            1
            

        }
    }
}
