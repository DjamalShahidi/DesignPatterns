using Prototype;
// The intent of this pattern is to specify the kinds of objects to create 
// using a prototypical instance,and create new objects by copying this prototype
Console.Title = "Portotype";

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned :{managerClone.Name}");

var employee = new Employee("Kevin", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned :{employeeClone.Name}, with manager {employeeClone.Manager.Name}");

managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned :{employeeClone.Name}, with manager {employeeClone.Manager.Name}");



Console.ReadKey();
