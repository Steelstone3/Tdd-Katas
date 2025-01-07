using System.Runtime.InteropServices;
using Xunit;

public class NinjaShould
{
    private readonly INinja ninja = new Ninja();

    [Fact]
    public void Attac()
    {
        // Given
        uint expectedDamage = 5;

        // When
        uint damage = ninja.Attac();

        // Then
        Assert.Equal(expectedDamage, damage);
    }

    [Theory]
    [InlineData(0, 100)]
    [InlineData(1, 99)]
    [InlineData(5, 95)]
    [InlineData(10, 90)]
    [InlineData(15, 85)]
    [InlineData(99, 1)]
    [InlineData(100, 0)]
    [InlineData(101, 0)]
    [InlineData(105, 0)]
    [InlineData(110, 0)]
    public void Protec(uint damage, uint expectedHealth)
    {
        // When
        ninja.Protec(damage);

        // Then
        Assert.Equal(expectedHealth, ninja.Health);
    }
}