using System;
using NinjaWars.Models;
using NinjaWars.Presenters;

namespace BubblesDivePlanner.Presenters
{
    public class Presenter : IPresenter
    {
        public void PrintTurn(INinja attackingNinja, INinja defendingNinja)
        {
            Console.WriteLine($"Ninja {attackingNinja.Name} stabs ninja {defendingNinja.Name}");
            Console.WriteLine($"Ninja {defendingNinja.Name} Health: {defendingNinja.Health}");
        }
    }
}
