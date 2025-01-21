using System.Data;

public class House
{
    int width = 0;
    int length = 0;
    bool hasGarage = false;
    bool hasSwimmingPool = false;
    bool hasHeating = false;

    public House(int width, int length, bool hasGarage, bool hasSwimmingPool, bool hasHeating)
    {

    }
}

public class HouseBuilder
{
    int width = 0;
    int length = 0;
    bool hasGarage = false;
    bool hasSwimmingPool = false;
    bool hasHeating = false;

    public void WithWidth(int width)
    {
        this.width = width;
    }

    public void WithLength(int length)
    {
        this.length = length;
    }

    public void WithGarage()
    {
        hasGarage = true;
    }

    public void WithSwimmingPool()
    {
        hasSwimmingPool = true;
    }

    public void WithHeating()
    {
        hasHeating = true;
    }

    public House Create()
    {
        return new House(width, length, hasGarage, hasSwimmingPool, hasHeating);
    }
}