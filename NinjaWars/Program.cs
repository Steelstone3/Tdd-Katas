using BubblesDivePlanner.Presenters;
using NinjaWars.Controllers;
using NinjaWars.Models;

namespace BubblesDivePlanner
{
    internal static class Program
    {
        internal static void Main()
        {
            INinja ninjaDerek = new Ninja("Derek");
            INinja ninjaSteve = new Ninja("Steve");

            BattleService battleService = new(new Presenter());

            battleService.Turn(ninjaDerek, ninjaSteve);
            battleService.Turn(ninjaSteve, ninjaDerek);
        }
    }
}
