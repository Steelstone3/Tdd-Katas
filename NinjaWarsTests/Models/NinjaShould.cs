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

    // [Fact]
    // public void Protec()
    // {
    //     // Given

    //     // When

    //     // Then
    // }
}