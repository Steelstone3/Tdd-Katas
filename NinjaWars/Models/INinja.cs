public interface INinja
{
    void ProtectYourself(IWeapon weapon);
    int DealSomeDamage();
    IWeapon Weapon { get; }
}