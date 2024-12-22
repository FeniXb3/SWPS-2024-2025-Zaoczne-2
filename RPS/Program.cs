//                         0       1         2
string[] allowedSigns = ["fire", "water", "grass"];

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

string firstSign = GetSign(1);
string secondSign = GetSign(2);

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

// typ_zwracanych_danych NazwaMetody(typ_danej danaPierwsza, typ_danej danaDruga)
string GetSign(int playerNumber)
{
    Console.WriteLine($"Graczu {playerNumber}, podaj znak ({string.Join("/", allowedSigns)})");
    string? sign = Console.ReadLine();
    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak");
        Console.WriteLine($"Graczu {playerNumber}, podaj POPRAWNY znak ({string.Join("/", allowedSigns)})");
        sign = Console.ReadLine();
    }

    return sign;
}