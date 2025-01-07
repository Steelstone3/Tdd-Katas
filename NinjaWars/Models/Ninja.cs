public class Ninja : INinja
{
    public uint Health { get; private set; } = 100;

    public uint Attac() => 5;

    public void Protec(uint damage)
    {
        Health -= damage;
    }
}