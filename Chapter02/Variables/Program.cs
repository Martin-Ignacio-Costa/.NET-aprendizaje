using System.Text.Json.Serialization;
using System.Dynamic;
using System.Xml;

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters");

dynamic something;
something = new[] { 3, 5, 7 };
//something = 12;
//something = "Ahmed";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

dynamic person = new ExpandoObject();

person.FirstName = "John";
person.LastName = "Doe";
person.Age = 30;

Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");

var dictionary = (IDictionary<string, object>)person;

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}

int population = 67_000_000;
double weight = 1.88;
decimal price = 4.99M;
string fruit = "Apples";
char letter = 'Z';
bool happy = true;

//var population = 67_000_000;
//var weight = 1.88;
//var price = 4.99M;
//var fruit = "Apples";
//var letter = 'Z';
//var happy = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");

Console.Write("A");
Console.Write("B");
Console.Write("C");

