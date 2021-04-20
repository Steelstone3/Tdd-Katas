using FizzBuzzGame.Controllers;

namespace FizzBuzzGame
{
    public class Game
    {
        private GameController _gameController = new GameController();

        public string PlayRound(uint value)
        {
            var fizzBuzz = _gameController.DetermineFizzBuzz(value);
            var fizz = _gameController.DetermineFizz(value);
            var buzz = _gameController.DetermineBuzz(value);

            return ReturnResult(value, fizzBuzz, fizz, buzz);
        }

        private string ReturnResult(uint value, string fizzBuzz, string fizz, string buzz)
        {
            switch (fizzBuzz)
            {
                case null when fizz == null && buzz == null:
                    return value.ToString();
                default:
                    if (fizzBuzz != null)
                    {
                        return fizzBuzz;
                    }
                    else if (fizz != null)
                    {
                        return fizz;
                    }
                    else if (buzz != null)
                    {
                        return buzz;
                    }
                    break;
            }

            return null;
        }
    }
}
