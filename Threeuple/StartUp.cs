using System;

public class StartUp
{
    public static void Main()
    {

        var input = Console.ReadLine().Split();
        var names = $"{input[0]} {input[1]}";
        var address = input[2];
        var city = input[3];
        var firstThree = new Threeuple<string, string, string>(names, address, city);

        var secondInput = Console.ReadLine().Split();
        var name = secondInput[0];
        var litersOfBeer = int.Parse(secondInput[1]);
        var drunkOrNot = secondInput[2];
        if (drunkOrNot == "drunk")
        {
            drunkOrNot = "True";
        }
        else
        {
            drunkOrNot = "False";
        }
        var secondThree = new Threeuple<string, int, string>(name, litersOfBeer, drunkOrNot);

        var thirdInput = Console.ReadLine().Split();
        var nameof = thirdInput[0];
        var accBalance = double.Parse(thirdInput[1]);
        var bankName = thirdInput[2];
        var thirdThree = new Threeuple<string, double, string>(nameof, accBalance, bankName);

        Console.WriteLine(firstThree);
        Console.WriteLine(secondThree);
        Console.WriteLine(thirdThree);
    }
}