using System;
using FactoryMethod;

//The intent of the factory method pattern is to define an interface for 
//creating an object,but to let subclasses decide which class to instantiate.
//Factory method lets a class defer instantiation to subclasses.
Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscoutFacotry("BE")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} comming from {discountService}");
}
Console.ReadKey();
