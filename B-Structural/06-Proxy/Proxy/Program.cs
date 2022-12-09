//The intent of this patten it to provide a surrogate or placeholder for 
//another object to control access to it.
Console.Title = "Proxy";

Console.WriteLine("Constracting document");
var myDocument = new Proxy.Document("MyDocument.pdf");
Console.WriteLine("Document constracted");
myDocument.DisplayDocument();


Console.WriteLine("Constracting document proxy");
var myDocumentProxy = new Proxy.DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constracted");
myDocumentProxy.DisplayDocument();

Console.WriteLine("Constracting document proxy");
var myLazyDocumentProxy = new Proxy.LazyDocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constracted");
myLazyDocumentProxy.DisplayDocument();

Console.WriteLine("Constracting protected document proxy");
var myProtectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Document proxy constracted");
myProtectedDocumentProxy.DisplayDocument();

Console.ReadKey();
