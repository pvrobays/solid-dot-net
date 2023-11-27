namespace _2.Composition;

public class HybridEngine(IEnergyStorage petrolStorage, IEnergyStorage electricStorage) : IEngine {
    public void Start() {
        PutFuelInCombustionChamber();
        IgniteCombustion();
        SwitchElectricityFromBatteryOn();
        //...
        Console.WriteLine("Engines started!");
        return;

        void SwitchElectricityFromBatteryOn() { }
        void IgniteCombustion() { }
        void PutFuelInCombustionChamber() { }
    }

    public void Refuel() {
        // ...
        Console.WriteLine("Refueled!");
    }
}