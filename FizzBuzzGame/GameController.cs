namespace FizzBuzzGame.Controllers
{
    public class GameController
    {
        public string DetermineFizzBuzz(uint value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                if (value.ToString().Contains("3"))
                {
                    return "FizzFizzBuzz";
                }
                else if (value.ToString().Contains("5"))
                {
                    return "FizzBuzzBuzz";
                }
                else
                {
                    return "FizzBuzz";
                }
            }

            return null;
        }

        public string DetermineFizz(uint value)
        {
            if (value % 3 == 0)
            {
                if (value.ToString().Contains("3"))
                {
                    return "FizzFizz";
                }
                else
                {
                    return "Fizz";
                }
            }

            return null;
        }

        public string DetermineBuzz(uint value)
        {
            if (value % 5 == 0)
            {
                if (value.ToString().Contains("5"))
                {
                    return "BuzzBuzz";
                }
                else
                {
                    return "Buzz";
                }
            }

            return null;
        }
    }
}
