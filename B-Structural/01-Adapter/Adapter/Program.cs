//using ObjectAdapter;
using ClassAdapter;
//The intent of  this pattern is to convert the interface of a class into 
//another interface clients expect.Adapter lets classes work together
//that couldn't otherwise because of incompatible interfaces.
Console.Title = "Adapter";

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName} ,{city.Inhabitants}");

Console.ReadKey();
