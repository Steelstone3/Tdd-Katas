namespace NinjaWars.Models
{
    public interface INinja
    {
        int Health { get; }
        string Name { get; }

        int Attack();
        void TakeDamage(int damage);
    }
}