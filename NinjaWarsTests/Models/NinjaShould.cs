using Xunit;

public class NinjaShould
{
    private readonly INinja ninja = new Ninja();

    [Fact]
    public void Attac()
    {
        // Given
        int expectedDamage = 5;

        // When
        int damage = ninja.Attac();

        // Then
        Assert.Equal(expectedDamage, damage);
    }

    [Fact]
    public void Protec()
    {
        // Given
        int damage = 0;
        uint expectedHealth = 100;

        // When
        ninja.Protec(damage);
        
        // Then
        Assert.Equal(expectedHealth, ninja.Health);
    }
}