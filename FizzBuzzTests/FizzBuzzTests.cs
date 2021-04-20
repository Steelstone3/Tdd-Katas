using Xunit;
using FizzBuzzGame;

namespace FizzBuzzTests
{
    public class FizzBuzzGameTests
    {
        //Write a function that takes positive integers and outputs their string representation.

        //Your function should comply with the following additional rules

        private Game game = new Game();

        //If the number isn't a multiple of three or 5 return value
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(11, "11")]
        [InlineData(13, "13")]
        public void TestValueReturned(uint value, string expectedResult)
        {
            Assert.Equal(expectedResult, game.PlayRound(value));
        }

        //If the number is a multiple of three, return the string "Fizz".
        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        public void TestFizzReturned(uint value)
        {
            Assert.Equal("Fizz", game.PlayRound(value));
        }

        //If the number is a multiple of five, return the string "Buzz".
        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(40)]
        [InlineData(70)]
        public void TestBuzzReturned(uint value)
        {
            Assert.Equal("Buzz", game.PlayRound(value));
        }


        //If the number is a multiple of both three and five, return the string "FizzBuzz".
        [Theory]
        [InlineData(90)]
        [InlineData(60)]
        public void TestFizzBuzzReturned(uint value)
        {
            Assert.Equal("FizzBuzz", game.PlayRound(value));
        }

        //If the number 3 itself appears in the number, return "FizzFizz" in place of "Fizz"
        [Theory]
        [InlineData(3)]
        [InlineData(33)] //Expected "FizzFizz"
        [InlineData(36)]
        [InlineData(39)]
        public void TestFizzFizzReturned(uint value)
        {
            Assert.Equal("FizzFizz", game.PlayRound(value));
        }

        //If the number 5 itself appears in the number, return "BuzzBuzz" in place of "BuzzBuzz"
        [Theory]
        [InlineData(5)]
        [InlineData(55)] //Expected "BuzzBuzz"
        [InlineData(565)] //Expected "BuzzBuzz"
        [InlineData(65)]
        public void TestBuzzBuzzReturned(uint value)
        {
            Assert.Equal("BuzzBuzz", game.PlayRound(value));
        }

        //If the number 5 itself appears in the number and the number is a multiple of 3 and 5, return "FizzBuzzBuzz" in place of "BuzzBuzz"
        [Theory]
        [InlineData(45)]
        public void TestFizzBuzzBuzzReturned(uint value)
        {
            Assert.Equal("FizzBuzzBuzz", game.PlayRound(value));
        }

        //If the number 3 itself appears in the number and the number is a multiple of 3 and 5, return "FizzFizzBuzz" in place of "FizzFizz"
        [Theory]
        [InlineData(30)]
        public void TestFizzFizzBuzzReturned(uint value)
        {
            Assert.Equal("FizzFizzBuzz", game.PlayRound(value));
        }
    }
}
