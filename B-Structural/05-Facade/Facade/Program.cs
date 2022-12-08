using Facade;
//The intent of this pattern is to provide a unified interface to a set of 
//interfaces in a subsystem. It defines a higher-level interface that makes 
//the subsystems easier to use.

Console.Title = "Facade";

var facade = new DiscountFacade();
Console.WriteLine($"Discount percentage for customer with id 1 : {facade.CalcualteDiscountPercentage(1)}");
Console.WriteLine($"Discount percentage for customer with id 10 : {facade.CalcualteDiscountPercentage(10)}");

Console.ReadKey();
