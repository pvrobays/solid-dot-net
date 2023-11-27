namespace _1.Inheritance;

public abstract class Car {
    public string Brand { get; set; }
    public string Model { get; set; }

    public abstract void StartEngine();
}

public abstract class CombustionCar : Car {
    public PetrolTypeEnum PetrolType { get; set; }

    public abstract void Refuel(PetrolTypeEnum fuel);

    public override void StartEngine() {
        PutFuelInCombustionChamber();
        IgniteCombustion();
        //...
        
        Console.WriteLine("Engine started!");
        return;

        void IgniteCombustion() { }
        void PutFuelInCombustionChamber() { }
    }
}

public class PetrolCar : CombustionCar {
    public override void Refuel(PetrolTypeEnum fuel) {
        if (fuel != PetrolTypeEnum.Petrol) {
            throw new InvalidFuelException();
        }
        // ...
        
        Console.WriteLine("Refueled!");
    }
}

public class DieselCar : CombustionCar {
    public override void Refuel(PetrolTypeEnum fuel) {
        if (fuel != PetrolTypeEnum.Diesel) {
            throw new InvalidFuelException();
        }
        // ...
        
        Console.WriteLine("Refueled!");
    }
}

public class ElectricCar : Car {
    public int BatteryChargeLevel { get; set; }

    public override void StartEngine() {
        if (BatteryChargeLevel <= 0) {
            throw new NoChargeException();
        }

        SwitchElectricityFromBatteryOn();
        // ...
        return;

        void SwitchElectricityFromBatteryOn() { }
    }

    public void Charge()
    {
        //...
        
        Console.WriteLine("Charged!");
    }
}

public enum PetrolTypeEnum
{
    Petrol,
    Diesel,
    LPG,
}

public class InvalidFuelException : Exception { }

public class NoChargeException : Exception { }