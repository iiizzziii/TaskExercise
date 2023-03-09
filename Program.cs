
namespace TaskTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Runner();
        }

        static async Task Runner()
        {
            var final = await Calc();
            System.Console.WriteLine($"4 - ----{final}-----");
        }

        static async Task<int> Calc()
        {
            var result1 = await Task.Run(() => {  return One();  });

            var result2 = await Task.Run(() => {  return Two(result1);  });

            var result3 = await Task.Run(() => {  return Three(result2);  });

            return result3;
        }

        static int One()
        {
            Thread.Sleep(3000);

            int one = new Random().Next(1, 1000);

            System.Console.WriteLine($"1 - generated int {one}");

            return one;
        }

        static int Two(int one)
        {
            int two = one % 13;

            System.Console.WriteLine($"2 - {one} % 13 = {two}");

            return two;
        }

        static int Three(int two)
        {
            int three = two * 3;

            System.Console.WriteLine($"3 - {two} * 3 = {three}");

            return three;
        }

    }
}