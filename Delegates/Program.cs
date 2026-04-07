public class Delegate
{
    public delegate void CallBack(string message);
    public delegate int CallBack1(int a, int b);

    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public static void Main(string[] args)
    {
        CallBack callBack = DelegateMethod;
        callBack("Hello world!");

        Delegate del = new Delegate();
        CallBack1 callBack1 = del.Add;
        Console.WriteLine(callBack1(1, 2));

        // Using Action delegate
        Action<string> printName = name => Console.WriteLine(name);
        printName("Manish Lama");

        // Using Func delegate
        Func<string, int, string> nameAndAge = (name, age) => $"{name} is {age} years old.";
        Console.WriteLine(nameAndAge("Manish", 23));

        // Using Predicate delegate
        Predicate<int> isYoung = age => age < 30;
        Console.WriteLine($"Is young: {isYoung(23)}");
    }
}