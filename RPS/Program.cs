//                         0       1         2
string[] allowedSigns = ["fire", "water", "grass"];

Console.WriteLine("Zagrajmy w rock paper scissors");
Console.WriteLine($"Graczu 1, podaj znak ({string.Join("/", allowedSigns)})");
string? firstSign = Console.ReadLine();
// dopóki warunek w nawiasie okrągłymjest spełniony, wykonaj to, co jest w nawiasie klamrowym poniżej
while (firstSign != allowedSigns[0] && firstSign != allowedSigns[1] && firstSign != allowedSigns[2])
{
    Console.WriteLine("Niepoprawny znak");
    Console.WriteLine($"Graczu 1, podaj POPRAWNY znak ({string.Join("/", allowedSigns)})");
    firstSign = Console.ReadLine();
}

Console.WriteLine("Graczu 2, podaj znak (rock/paper/scissors)");
string? secondSign = Console.ReadLine();

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