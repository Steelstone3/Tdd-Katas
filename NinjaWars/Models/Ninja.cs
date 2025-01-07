public class Ninja : INinja
{
    public uint Health { get; }

    public int Attac() => 5;

    public void Protec(int damage)
    {
        throw new System.NotImplementedException();
    }
}