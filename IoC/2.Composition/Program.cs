// See https://aka.ms/new-console-template for more information


using _2.Composition;

var petrolEngine = new PetrolEngine(new PetrolStorage());
var bmw1Series = new Car(petrolEngine) { Brand = "BMW", Model = "1 series" };

var electricEngine = new ElectricEngine(new ElectricStorage());
var TeslaS = new Car(electricEngine) { Brand = "Tesla", Model = "S" };

Console.WriteLine("Cars created");

bmw1Series.Refuel();
TeslaS.Refuel();

// Start the cars...
bmw1Series.StartEngine();
TeslaS.StartEngine();

//Now the customer wants to make Hybrid cars..

var hybridEngine = new HybridEngine(new PetrolStorage(), new ElectricStorage());
var toyotaPrius = new Car(hybridEngine) { Brand = "Toyota", Model = "Prius" };

toyotaPrius.Refuel();
toyotaPrius.StartEngine();
