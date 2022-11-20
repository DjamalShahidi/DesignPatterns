using Singleton;

//The intent of the Singleton pattern is to ensure that a class
//1-Only has one instance 
//2-Provide a global point of access to it 
//----------
//Real-life example:
//1-Logger
//----------
//Note
//1-Prefer lazy instantiation
//----------
//Use case:
//1-When there must be exactly one instance of a class,and it must be accessible to 
//clinet from well-known access point
//2-When the sole instance should be extensible by subclassing ,and clints should be
//able to use an extended instance without modifying their code
//

Console.Title = "Singleton pattern";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;


if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

instance1.Log($"Message from {nameof(instance1)}");
instance2.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.ReadLine();


