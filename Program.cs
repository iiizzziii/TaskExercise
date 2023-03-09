
namespace TaskTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Runner();
            System.Console.Read();
        }

        static async Task Runner()
        {
            await Calc();
        }

        static async Task Calc()
        {
            int result2 = await Calc1_2();

            Calc3(result2);
        }

        static async Task<int> Calc1_2()
        {
            var result1 = await Task.Run(() => {  return Calc1();  });

            var result2 = await Task.Run(() => {  return Calc2(result1);  });

            return result2;
        }

        static int Calc1()
        {
            Thread.Sleep(3000);

            int one = new Random().Next(1, 1000);

            System.Console.WriteLine($"1 - generated int {one}");

            return one;
        }

        static int Calc2(int one)
        {
            int two = one % 13;

            System.Console.WriteLine($"2 - {one} % 13 = {two}");

            return two;
        }

        static void Calc3(int two)
        {
            int result = two * 3;

            System.Console.WriteLine($"3 - {two} * 3 = {result}");
        }

    }
}