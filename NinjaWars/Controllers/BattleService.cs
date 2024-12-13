using System;
using BubblesDivePlanner.Presenters;
using NinjaWars.Models;
using NinjaWars.Presenters;

namespace NinjaWars.Controllers;

public class BattleService
{
    private readonly IPresenter presenter;

    public BattleService(IPresenter presenter)
    {
        this.presenter = presenter;
    }

    public void Turn(INinja attackingNinja, INinja defendingNinja)
    {
        int damage = attackingNinja.Attack();
        defendingNinja.TakeDamage(damage);
        presenter.PrintTurn(attackingNinja, defendingNinja);
    }
}