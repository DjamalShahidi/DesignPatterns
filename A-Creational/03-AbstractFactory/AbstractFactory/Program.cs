using AbstractFactory;

//The intent of the abstract factory pattern is to provide an interface for 
//careating families of related or dependent objects without specifying 
//their concrete classes
Console.Title = "Abstract Factory";

var belguimShoppingCartPurchaseFactory = new BelgiumShippingCartPurchaseFactory();

var shoppingCartForBelgium = new ShippingCart(belguimShoppingCartPurchaseFactory);

shoppingCartForBelgium.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShippingCartPurchaseFactory();

var shoppingCartForFrance = new ShippingCart(franceShoppingCartPurchaseFactory);

shoppingCartForFrance.CalculateCosts();


Console.ReadKey();