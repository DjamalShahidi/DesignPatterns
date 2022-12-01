using Bridge;
//The intent of this pattern is to decouple an abstraction from its 
//implementation so the two can very independently

Console.Title = "Bridge";
var noCoupon = new NoCoupon();
var oneEuroCoupon = new OneEuroCoupon();

var meatBaseMenu = new MeatBaseMenu(noCoupon);
Console.WriteLine($"Meat based menu ,no coupon :{meatBaseMenu.CalculatePrice()} euro.");

meatBaseMenu = new MeatBaseMenu(oneEuroCoupon);
Console.WriteLine($"Meat based menu ,one euro  coupon :{meatBaseMenu.CalculatePrice()} euro.");

var vegetrainMenu = new VegetrainMenu(noCoupon);
Console.WriteLine($"Vegetrain based menu ,no coupon :{vegetrainMenu.CalculatePrice()} euro.");

vegetrainMenu = new VegetrainMenu(oneEuroCoupon);
Console.WriteLine($"Vegetrain based menu ,one euro  coupon :{vegetrainMenu.CalculatePrice()} euro.");

Console.ReadKey();