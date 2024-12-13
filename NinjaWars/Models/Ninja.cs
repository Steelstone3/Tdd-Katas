namespace NinjaWars.Models
{
    public class Ninja : INinja
    {
        public Ninja(string name)
        {
            Name = name;
        }

        public int Health { get; private set; } = 100;

        public string Name {get; private set; }

        public int Attack()
        {
            return 2;
        }

        public void TakeDamage(int damage)
        {
            if (damage <= Health)
            {
                Health -= damage;
            }
            else
            {
                Health = 0;
            }
        }
    }
}