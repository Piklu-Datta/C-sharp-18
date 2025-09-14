

using Reflection;

class Pogram
{
    static void Main(string[] args)
    {
        Type type = typeof(Person);
        Console.WriteLine($"Type: {type.Name}");

        Console.WriteLine("Properties");
        
        var properties = type.GetProperties();

        foreach(var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("Methods");
        var methods =type.GetMethods();

        foreach(var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}