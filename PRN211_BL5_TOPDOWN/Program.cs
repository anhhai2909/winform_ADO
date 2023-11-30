
passParameter();
partial class Program
{
    static void varType()
    {
        var myInt = 0;
        var myBool = true;
        var myString = "Hello world ? ";
        var myDouble = 0.5;

        Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
        Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
        Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
        Console.WriteLine();
    }
    static void dynamicType()
    {
        dynamic myValue = 0;
        Console.WriteLine("myValue type is a : {0}", myValue.GetType().Name);
        myValue = true;
        Console.WriteLine("myValue type is a : {0}", myValue.GetType().Name);
        myValue = "Hello world !";
        Console.WriteLine("myValue type is a : {0}", myValue.GetType().Name);
        myValue = 0.5;
        Console.WriteLine("myValue type is a : {0}", myValue.GetType().Name);
        Console.WriteLine();
    }
    static void stringInterpolation()
    {
        String name = "Nguyen Anh Hai";
        int age = 20;
        Console.WriteLine($"Hello {name} !");
        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine();
    }

    static void passParameter()
    {
        int a = 1;
        int b;
        getParameter(ref a, out b);
        Console.WriteLine($"a: {a}; b: {b}");
    }
    static void getParameter(ref int a, out int b)
    {
        a = 2;
        b = 1;
    }

}


