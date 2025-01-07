public class Ninja : INinja
{
    public uint Health { get; private set; } = 100;

    public int Attac() => 5;

    public void Protec(int damage)
    {

    }
}