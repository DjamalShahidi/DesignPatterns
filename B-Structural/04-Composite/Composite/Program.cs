//The intent of this pattern is to compose objects into tree structures to 
//represent part-whole hierarchies.As such ,it lets client treat individual 
//objects to compositions of objects uniformly:as if they all where individual objects.
Console.Title = "Composite";

var root = new Composite.Directory("root", 0);
var topLevelFile = new Composite.File("toplevel.txt", 100);
var topLevelDirectory1 = new Composite.Directory("topleveldirectory1", 4);
var topLevelDirectory2 = new Composite.Directory("topleveldirectory2", 4);

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);


var subLevelFile1 = new Composite.File("sublevel1.txt", 200);
var subLevelFile2 = new Composite.File("sublevelFile2.txt", 150);

topLevelDirectory2.Add(subLevelFile1);
topLevelDirectory2.Add(subLevelFile2);

Console.WriteLine($"Size of toplevelDirectory1: {topLevelDirectory1.GetSize()}");
Console.WriteLine($"Size of toplevelDirectory2: {topLevelDirectory2.GetSize()}");
Console.WriteLine($"Size of root :{root.GetSize()}");


Console.ReadKey();


