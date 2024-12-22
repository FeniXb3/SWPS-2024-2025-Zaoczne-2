//                         0       1         2
string[] allowedSigns = ["fire", "water", "grass"];
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
int expectedPoints = 3;

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

while (!(firstPlayerPoints == expectedPoints || secondPlayerPoints == expectedPoints))
{
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
        // firstPlayerPoints = firstPlayerPoints + 1;
        firstPlayerPoints += 1;
        // firstPlayerPoints++;
    }
    else
    {
        Console.WriteLine("G2 MISZCZ!");
        secondPlayerPoints += 1;
    }
    Console.WriteLine($"G1: {firstPlayerPoints} - G2: {secondPlayerPoints}");

    // if (firstPlayerPoints == expectedPoints || secondPlayerPoints == expectedPoints)
    // {
    //     break;
    // }
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