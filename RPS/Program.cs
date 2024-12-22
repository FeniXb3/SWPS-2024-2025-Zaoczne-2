//                         0       1         2
string[] allowedSigns = ["fire", "water", "grass"];

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");
Console.WriteLine($"Graczu 1, podaj znak ({string.Join("/", allowedSigns)})");
string? firstSign = Console.ReadLine();
while (!allowedSigns.Contains(firstSign))
{
    Console.WriteLine("Niepoprawny znak");
    Console.WriteLine($"Graczu 1, podaj POPRAWNY znak ({string.Join("/", allowedSigns)})");
    firstSign = Console.ReadLine();
}

Console.WriteLine($"Graczu 2, podaj znak ({string.Join("/", allowedSigns)})");
string? secondSign = Console.ReadLine();
while (!allowedSigns.Contains(secondSign))
{
    Console.WriteLine("Niepoprawny znak");
    Console.WriteLine($"Graczu 2, podaj POPRAWNY znak ({string.Join("/", allowedSigns)})");
    secondSign = Console.ReadLine();
}

if (firstSign == secondSign)
{
    Console.WriteLine("Remis");
    Console.WriteLine("Ależ jesteście zgodni");
}
else if ((firstSign == allowedSigns[0] && secondSign == allowedSigns[2]) 
        || (firstSign == allowedSigns[1] && secondSign == allowedSigns[0]) 
        || (firstSign == allowedSigns[2] && secondSign == allowedSigns[1]))
{
    Console.WriteLine("G1 MISZCZ!");
} 
else
{
    Console.WriteLine("G2 MISZCZ!");
}

Console.WriteLine("GG");