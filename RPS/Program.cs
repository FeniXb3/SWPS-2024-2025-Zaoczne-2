const string firstAllowedSign = "fire";
const string secondAllowedSign = "water";
const string thirdAllowedSign = "grass";

Console.WriteLine("Zagrajmy w rock paper scissors");
Console.WriteLine($"Graczu 1, podaj znak ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
string? firstSign = Console.ReadLine();

while (firstSign != firstAllowedSign && firstSign != secondAllowedSign && firstSign != thirdAllowedSign)
{
    Console.WriteLine("Niepoprawny znak");
    Console.WriteLine($"Graczu 1, podaj POPRAWNY znak ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
    firstSign = Console.ReadLine();
}

Console.WriteLine("Graczu 2, podaj znak (rock/paper/scissors)");
string? secondSign = Console.ReadLine();

if (firstSign == secondSign)
{
    Console.WriteLine("Remis");
    Console.WriteLine("Ależ jesteście zgodni");
}
else if ((firstSign == firstAllowedSign && secondSign == thirdAllowedSign) 
        || (firstSign == secondAllowedSign && secondSign == firstAllowedSign) 
        || (firstSign == thirdAllowedSign && secondSign == secondAllowedSign))
{
    Console.WriteLine("G1 MISZCZ!");
} 
else
{
    Console.WriteLine("G2 MISZCZ!");
}

Console.WriteLine("GG");