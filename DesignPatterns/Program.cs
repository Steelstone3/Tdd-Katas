using BubblesDivePlanner.Presenters;

namespace NinjaWars
{
    internal static class Program
    {
        internal static void Main()
        {
            var vechile = new VechileFactory().Create();

            var houseBuilder = new HouseBuilder();
            houseBuilder.WithGarage();
            houseBuilder.WithLength(10);
            houseBuilder.WithWidth(10);

            var house = houseBuilder.Create();
        }
    }
}
