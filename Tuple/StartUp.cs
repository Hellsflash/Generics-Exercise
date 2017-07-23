using System;

public class StartUp
{
    public static void Main()
    {
        var firstPair = Console.ReadLine().Split();
        var names = $"{firstPair[0]} {firstPair[1]}";
        var addres = firstPair[2];
        var firstTuple = new Tuple<string, string>(names, addres);

        var secondPair = Console.ReadLine().Split();
        var name = secondPair[0];
        var beerAmount = int.Parse(secondPair[1]);
        var secondTuple = new Tuple<string, int>(name, beerAmount);

        var thirdPair = Console.ReadLine().Split();
        var intItem = int.Parse(thirdPair[0]);
        var doubleItem = double.Parse(thirdPair[1]);
        var thirdTuple = new Tuple<int, double>(intItem, doubleItem);

        Console.WriteLine(firstTuple);
        Console.WriteLine(secondTuple);
        Console.WriteLine(thirdTuple);
    }
}