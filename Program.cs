namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            System.Console.Read();
        }

        async static void Test()
        {
            await Calc();
        }

        async static Task Calc()
        {
            await Calc1_2();

            Calc3();
        }

        async static Task Calc1_2()
        {
            var result1 = await Task.Run(() => {  return Calc1();  });

            Calc2(result1);
        }

        static int Calc1()
        {
            Thread.Sleep(3000);
            System.Console.WriteLine("calculating result 1");
            return 100;
        }

        static int Calc2(int result1)
        {
            System.Console.WriteLine("calculating result 2");
            return result1 * 2;
        }

        static int Calc3()
        {
            System.Console.WriteLine("calculating result 3");
            return 300;
        }

    }
}