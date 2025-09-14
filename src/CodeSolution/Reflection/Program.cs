

using Reflection;

class Pogram
{
    static void Main(string[] args)
    {
        //Type type = typeof(Person);
        //Console.WriteLine($"Type: {type.Name}");

        //Console.WriteLine("Properties");

        //var properties = type.GetProperties();

        //foreach(var property in properties)
        //{
        //    Console.WriteLine(property.Name);
        //}

        //Console.WriteLine("Methods");
        //var methods =type.GetMethods();

        //foreach(var method in methods)
        //{
        //    Console.WriteLine(method.Name);
        //}

        Type type = typeof(Person2);

        object obj = Activator.CreateInstance(type,"Alice",100);

        var name = type.GetProperty("Name").GetValue(obj);

        var age = type.GetProperty("Id").GetValue(obj);

        Console.WriteLine($"Name: {name} Age: {age}");
    }
}