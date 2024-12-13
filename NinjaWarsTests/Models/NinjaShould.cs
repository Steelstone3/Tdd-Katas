using System;
using NinjaWars.Models;
using Xunit;

namespace NinjaWarsTests.Models
{
    public class NinjaShould
    {
        private INinja ninja;

        public NinjaShould()
        {
            ninja = new Ninja("Steve");
        }

        [Fact]
        public void Construct()
        {
            // Given
            string name = "Derek";

            // When
            ninja = new Ninja(name);

            // Then
            Assert.Equal(name, ninja.Name);
        }

        [Fact]
        public void Attack()
        {
            // Given
            int expectedDamage = 2;

            // When
            int damage = ninja.Attack();

            // Then
            Assert.Equal(expectedDamage, damage);
        }

        [Fact]
        public void TakeDamage()
        {
            // Given
            int expectedHealth = 98;
            int damage = 2;

            // When
            ninja.TakeDamage(damage);

            // Then
            Assert.Equal(expectedHealth, ninja.Health);
        }

        [Fact]
        public void TakeDamageWithoutGoingBelowZero()
        {
            // Given
            int expectedHealth = 0;
            int damage = 101;

            // When
            ninja.TakeDamage(damage);

            // Then
            Assert.Equal(expectedHealth, ninja.Health);
        }
    }
}