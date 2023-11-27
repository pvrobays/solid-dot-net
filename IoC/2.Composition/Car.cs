namespace _2.Composition;

public interface IEngine {
    void Start();
    void Refuel();
}

public interface IEnergyStorage {
    FuelTypeEnum Fuel { get; }
    int FuelLevel { get; }
    void AddFuel(int fuel);
    int GetFuel();
}

public class Car(IEngine engine)
{
    public required string Brand { get; set; }
    public required string Model { get; set; }

    public virtual void StartEngine() => engine.Start();

    public void Refuel() => engine.Refuel();
}

public class PetrolEngine(IEnergyStorage energyStorage) : IEngine {
    public void Start() {
        PutFuelInCombustionChamber();
        IgniteCombustion();
        //...
        Console.WriteLine("Engine started!");
        return;

        void IgniteCombustion() { }
        void PutFuelInCombustionChamber() { }
    }

    public void Refuel() {
        if (energyStorage.Fuel != FuelTypeEnum.Petrol) {
            throw new InvalidFuelException();
        }
        // ...
        Console.WriteLine("Refueled!");
    }
}

public class ElectricEngine(IEnergyStorage energyStorage) : IEngine {
    public void Start() {
        SwitchElectricityFromBatteryOn();
        // ...
        Console.WriteLine("Engine started!");
        return;

        void SwitchElectricityFromBatteryOn() { }
    }

    public void Refuel() {
        if (energyStorage.Fuel != FuelTypeEnum.Electric) {
            throw new InvalidFuelException();
        }
        // ...
        Console.WriteLine("Refueled!");
    }
}

public class InvalidFuelException : Exception;

public enum FuelTypeEnum
{
    Petrol,
    Diesel,
    Electric
}