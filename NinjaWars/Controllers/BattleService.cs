public class BattleService : IBattleService
{
    public void Turn(INinja ninja1, INinja ninja2)
    {
        ninja2.Protec(ninja1.Attac());
        ninja1.Protec(ninja2.Attac());
    }
}