namespace FizzBuzzKata
{
    internal static class Program
    {
        internal static void Main()
        {
            IFizzBuzz fizzBuzz = new FizzBuzz();

            string result1 = fizzBuzz.Convert(1);
            string result2 = fizzBuzz.Convert(3);
            string result3 = fizzBuzz.Convert(5);
            string result4 = fizzBuzz.Convert(15);

            System.Console.WriteLine(result1);
            System.Console.WriteLine(result2);
            System.Console.WriteLine(result3);
            System.Console.WriteLine(result4);
        }
    }
}
