using System;

public class Vechile {
    int storageSize = 0;
    int width = 0;
    int length = 0;
    Engine engine = new();

    public Vechile(int storageSize, int width, int length, Engine engine)
    {
        
    }
}

public class Engine {

}

public class VechileFactory {
    public Vechile Create() {
        return new Vechile(500, 1000, 1000, new Engine());
    }
}