using NinjaWars.Models;

namespace NinjaWars.Presenters
{
    public interface IPresenter
    {
        void PrintTurn(INinja attackingNinja, INinja defendingNinja);
    }
}