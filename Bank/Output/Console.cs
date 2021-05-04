using Bank.Contracts;

namespace Bank
{
    public class Console : IConsole
    {
        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}