// See https://aka.ms/new-console-template for more information

using _1.Inheritance;

var bmw1Series = new PetrolCar() { Brand = "BMW", Model = "1 series", PetrolType = PetrolTypeEnum.Petrol };

var teslaS = new ElectricCar() { Brand = "Tesla", Model = "S", BatteryChargeLevel = 40 };

Console.WriteLine("Cars created");

// Start the cars...
bmw1Series.Refuel(PetrolTypeEnum.Petrol);
teslaS.Charge();

bmw1Series.StartEngine();
teslaS.StartEngine();



//Now the customer wants to make Hybrid cars...
// 🤯??