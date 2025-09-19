

using Reflection;
using System.Reflection;

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


        //Type type = typeof(Person2);

        //object obj = Activator.CreateInstance(type,"Alice",100);

        //var name = type.GetProperty("Name").GetValue(obj);

        //var age = type.GetProperty("Id").GetValue(obj);

        //Console.WriteLine($"Name: {name} Age: {age}");


        //Type type = typeof(Person3);

        //object person = Activator.CreateInstance(type);

        //var setInfoMethod = type.GetMethod("setInfo");

        //setInfoMethod.Invoke(person, new object[] {"Alice", 25 });

        //var displayMethod = type.GetMethod("displayInfo");
        //displayMethod.Invoke(person, null);



        //Type type = typeof(Person5);

        //ConstructorInfo? constructorInfo = type.GetConstructor(new Type[] { typeof(string), typeof(int)});
        //object person = constructorInfo.Invoke(new Object[] {"Alice",20});

        //var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        //foreach (var method in methods)
        //{
        //    if(method.GetParameters().Length == 0)
        //    {
        //       method.Invoke(person, null);
        //    }
        //}


        Assembly assembly = Assembly.GetExecutingAssembly();

        var types = assembly.GetTypes();
        foreach (var t in types)
        {
            var interfaces = t.GetInterfaces();

            if (interfaces.Any(x => x.Name == "IPurchaseable"))
            {
                ConstructorInfo? constructor = t.GetConstructor(new Type[] { typeof(string), typeof(double), typeof(double) });

                object? o = constructor?.Invoke(new object[] {"Camera", 3000, 10 });

                MethodInfo? method1 = t.GetMethod("CalculatePriceAfterTax", BindingFlags.Public | BindingFlags.Instance);
                MethodInfo? method2 = t.GetMethod("calculateDiscount", BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(double) }, null );

                double? r1 = (double?)method1?.Invoke(o, null);
                double? r2 = (double?)method2?.Invoke(o, new object[] {5});

                Console.WriteLine(r1);
                Console.WriteLine(r2);


            }
        }
  
       
    }
}