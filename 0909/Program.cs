 internal class Program
    {
        static void Main(string[] args)
        {
        ////var inputString = Console.ReadLine();
        ////Console.WriteLine(inputString);


        //var val1 = 1000L;
        //var val2 = 2000L;
        ////명시적 형변환(큰단위->작은단위)
        //int vala = (int)(val1 + val2);
        //Console.WriteLine(vala);

        ////암시적변환,묵시적변환(작은단위->큰단위) [자동 자료형 변환]
        //long valc = val1 + val2;
        //Console.WriteLine(valc);

        //var str = "20000";
        //val1=int.Parse(str); //문자열울 정수로 바꾸는것
        //val1= long.Parse(str);

        //val1.ToString();//문자열로 바꾸는거

        //var b1 = bool.Parse("True"); Console.WriteLine($"b1:type{b1.GetType()}");
        //var b2 = bool.Parse("false"); Console.WriteLine($"b2:type{b1.GetType()}");
        //var b3 = bool.Parse("TrUe"); Console.WriteLine($"b3:type{b1.GetType()}");

        int valmin = int.MinValue; Console.WriteLine(valmin);
        //valmin = 2147483648;
        //Console.WriteLine(-valmin);
        int valmax = int.MaxValue; Console.WriteLine(valmax);
    }
    }

//0909
//length 문자열 길이