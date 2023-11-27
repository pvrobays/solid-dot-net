namespace _2.Composition;

public class PetrolStorage : IEnergyStorage {
    public FuelTypeEnum Fuel => FuelTypeEnum.Petrol;
    public int FuelLevel { get; private set; }

    public void AddFuel(int fuel) {
        FuelLevel += fuel;
    }

    public int GetFuel() {
        var fuel = FuelLevel;
        FuelLevel = 0;
        return fuel;
    }
}

public class ElectricStorage : IEnergyStorage {
    public FuelTypeEnum Fuel => FuelTypeEnum.Electric;
    public int FuelLevel { get; private set; }

    public void AddFuel(int fuel) {
        FuelLevel += fuel;
    }

    public int GetFuel() {
        var fuel = FuelLevel;
        FuelLevel = 0;
        return fuel;
    }
}