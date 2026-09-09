namespace _2026031030_practice // 그룹이름(카테고리) 범주

{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("나의 이력서");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("이름 : 최하늘");
            //Console.WriteLine("특징 : 개성이강함 진짜 강함");

            ///260909 3주차
            ///
            //int a = 100;
            //int b = 200;
            //System.Console.WriteLine(a==b);
            //System.Console.WriteLine(a!=b);
            //System.Console.WriteLine(a <= b);

            //System.Console.WriteLine(a + b);
            //System.Console.WriteLine(a - b);
            //System.Console.WriteLine(a / b);
            //System.Console.WriteLine(a * b);
            //System.Console.WriteLine(a % b);

            //System.Console.WriteLine(sizeof(byte));
            //System.Console.WriteLine(sizeof(char));
            //System.Console.WriteLine(sizeof(short));
            //System.Console.WriteLine(sizeof(int));
            //System.Console.WriteLine(sizeof(long));
            //System.Console.WriteLine(sizeof(float));
            //System.Console.WriteLine(sizeof(double));

            //char value = '가';
            //char value1 = 'a';
            //char value2 = 'A';
            //System.Console.WriteLine(value1 + value2);
            //System.Console.WriteLine(value1 - value2);
            //System.Console.WriteLine(value1 * value2);
            //System.Console.WriteLine(value1 / value2);
            //System.Console.WriteLine(value1 % value2);

            // char value = '0';
            // System.Console.WriteLine(value - 0);

            // //System.Console.WriteLine(sizeof(byte));
            // //System.Console.WriteLine(sizeof(char));
            //// System.Console.WriteLine(sizeof(short));
            // System.Console.WriteLine(sizeof(int));
            // //System.Console.WriteLine(sizeof(long));
            // System.Console.WriteLine(sizeof(float));
            // //System.Console.WriteLine(sizeof(double));

            // string message1 = "안녕하세여 반갑습니다.a";
            // string message2 = "asdgh.dghlko,.";

            // System.Console.WriteLine(message1[0]);
            // System.Console.WriteLine(message1.Length);
            // System.Console.WriteLine(message2.Length); //문자열 길이를 알수 있다

            // int val12; //system.Int32 val12;

            //int value3 = 100;
            //value3 += 200;  Console.WriteLine(value3);
            //value3 -= 200;  Console.WriteLine(value3);
            //value3 *= 200;  Console.WriteLine(value3);
            //value3 /= 200;  Console.WriteLine(value3);
            //value3 %= 200;  Console.WriteLine(value3);

            //string m1 = "hello";
            //m1 += "world"; Console.WriteLine(m1);//m1=m1+"world";
            //m1=string.Concat("welcom");

            //string resDir = "resource/";
            //string textureFile = "m1.png";

            //string texpath = resDir;
            //texpath += textureFile;

            //Console.WriteLine(texpath);

            ////단항연산자
            //int value = 100;
            //int result = 0;
            //result=++value; 
            //Console.WriteLine($"result: {result} value:{value}"); //$를 붙히면 안에 변수명을 쓸 수 있다

            //result=value++; 
            //Console.WriteLine($"result: {result} value:{value}");
            ////value++;
            ////result = value;
            ////value = value + 1;

            //result = --value; Console.WriteLine($"result: {result} value:{value}");
            //result = value--; Console.WriteLine($"result: {result} value:{value}");
            ////value--;
            ////result = value;
            ////value = value - 1;

            ///GetType
            //Console.WriteLine(10.GetType());
            //Console.WriteLine(10.0F.GetType());
            //Console.WriteLine('한'.GetType());
            //Console.WriteLine("message".GetType());

            //var value = "안녕하세요"; 
            //Console.WriteLine("value type"+ value.GetType());

            var val0 = 0L      ;        Console.WriteLine($"value type : {val0.GetType()}");
            var val1 = 0       ;        Console.WriteLine($"value type : {val1.GetType()}");
            var val2 = 0.0     ;        Console.WriteLine($"value type : {val2.GetType()}");
            var val3 = 0.0F    ;        Console.WriteLine($"value type : {val3.GetType()}");
            var val4 = '가'    ;        Console.WriteLine($"value type : {val4.GetType()}");
            var val5 = "문자열";        Console.WriteLine($"value type : {val5.GetType()}");
            var val6 = val3    ;        Console.WriteLine($"value type : {val6.GetType()}");

            //var가 좋다 알아서 해주니깐



        }
    }
}
