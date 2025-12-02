
// Encapsulation

//BadBankAccount badBankAccount = new();
//badBankAccount.balance = 100;
//Console.WriteLine(badBankAccount.balance);

//BankAccount bankAccount = new(100);
//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Deposit(50);
//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.WithDraw(100);
//Console.WriteLine(bankAccount.GetBalance());

// Abstraction

// Reduce complexity by hiding unnecessary details

//EmailService emailService = new();
//emailService.Connect();
//emailService.Authenticate();
//emailService.SendEmail();
//emailService.Disconnect();

// Inheritance

// Inheritacne involves createing new classes (subclasses or derived classes) based on existing classes (superclasses or base classes
// Subclasses inherit properties and behaviors from their superclasses and can also add new features or override existiong ones. Inheritance
// os often described in terms of an "Is-A" relationship.

//Car car = new();

//car.Brand = "Ford";
//car.Start();
//car.Stop();

//car.NumberOfDoors = 4;

//Bike bike = new();
//bike.NumberOfWheels = 2;

// Ploymorphism



//Plane plane = new();

//plane.Start();
//plane.Stop();



//using Patterns.Polymorphism;

//List<Vehicle> vehicles = new List<Vehicle>();

//vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020 });
//vehicles.Add(new Motorcycle { Brand = "Victory", Model = "8-ball", Year = 2013 });
//vehicles.Add(new Airplane { Brand = "Boeing", Model = "747", Year = 2023 });


//// Vehicle inspection

//foreach (var vehicle in vehicles)
//{
//    vehicle.Start();
//}

/* Coupling
 * 
 * The degree of dependency between different classes
 
 */

//using Patterns.Coupling;

//Order order = new(new EmailSender());
//Order order2 = new(new SmsSender());
//order.PlaceOrder();
//order2.PlaceOrder();

/* Composistion
 * 
 * Composition involves creating complex objects by combining simpler objects or components.
 * In composition, objects are assembled together to form larger structures, with each component
 * object maintaining its own state and behavior. Composition is often described in terms of a
 * "Has-A" relationship.
 */

using Patterns.Composition;

Car car = new();
car.StartCar();