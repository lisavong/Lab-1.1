// Lab 1 - Number Analyzer
// Lisa Vongsiprasom

Console.WriteLine("Welcome to the number analyzer");
Console.WriteLine("What's your name?");
string name = Convert.ToString(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Nice to meet you {name}, pick a number between 1 and 100");
Console.WriteLine();


int num = Convert.ToInt32(Console.ReadLine());



if (num%2 > 0 && num < 60)
{
    Console.WriteLine($"{num} is odd and less than 60");

}

else if (num%2==0 && num < 25)
{
    Console.WriteLine($"{num} is even and less than 25");
}

else if (num%2==0 && num<=60 && num>=26)
{
    Console.WriteLine($"{num} is even and between 26 and 60 inclusive");
}

else if (num%2==0 && num>60)
{
    Console.WriteLine($"{num} is even and greater than 60");
}


else if (num%2!=0 && num > 60)
{
    Console.WriteLine($"{num} is odd and greater than 60");
}

Console.WriteLine();
Console.WriteLine($"Thanks {name}. Hit any key to exit");
Console.ReadKey();






