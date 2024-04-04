// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter your name");
var name = Console.ReadLine();
var myClass = new MyClass();
string result = myClass.Concat(name);
Console.WriteLine(result);