string message = "Hello, world!";
message.Print();
Console.WriteLine($"{message} has {message.WordCount()} characters.");

Car car = new Car();
car.Model("Tesla");
car.Price(100000);

public class Car
{
    public void Model(string model)
    {
        Console.WriteLine(model);
    }
}
public static class MyExtensions
{
    public static void Print(this string str)
    {
        Console.WriteLine(str);
    }

    public static int WordCount(this string str)
    {
        char[] letters = str.ToCharArray();
        int count = 0;
        foreach (char letter in letters)
        {
            count++;
        }

        return count;
    }

    public static void Price(this Car car, int price)
    {
        Console.WriteLine(price);
    }
}