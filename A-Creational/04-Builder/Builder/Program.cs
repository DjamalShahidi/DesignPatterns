using Builder;
// The intent of the builder pattern is to separate  the construction of 
// a complex object from its represention .By doing so, the same construction 
// process can create different representations.

Console.Title = "Builder";

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());
//or:
garage.Show();

garage.Construct(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());
//or:
garage.Show();

Console.ReadKey();