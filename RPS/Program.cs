﻿//                         0       1         2
string[] allowedSigns = ["fire", "water", "grass"];

string GetLowercaseInput()
{
    return (Console.ReadLine() ?? string.Empty).Trim().ToLower();
}

int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
int expectedPoints;
int minDefaultExpectedPoints = 3;
int maxDefaultExpectedPoints = 9;

Console.WriteLine("Do ilu punktów chcecie grać?");
bool result = int.TryParse(Console.ReadLine(), out expectedPoints);
if (result == false)
{
    expectedPoints = Random.Shared.Next(minDefaultExpectedPoints, maxDefaultExpectedPoints + 1);
    Console.WriteLine($"Niepoprawna wartość! Zagracie więc do {expectedPoints}");
}

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

while (firstPlayerPoints < expectedPoints && secondPlayerPoints < expectedPoints)
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
        firstPlayerPoints += 2;
        // firstPlayerPoints++;
    }
    else
    {
        Console.WriteLine("G2 MISZCZ!");
        secondPlayerPoints += 2;
    }
    Console.WriteLine($"G1: {firstPlayerPoints} - G2: {secondPlayerPoints}");

    // if (firstPlayerPoints >= expectedPoints || secondPlayerPoints >= expectedPoints)
    // {
    //     break;
    // }
}

Console.WriteLine("GG");

// typ_zwracanych_danych NazwaMetody(typ_danej danaPierwsza, typ_danej danaDruga)
string GetSign(int playerNumber)
{
    Console.WriteLine($"Graczu {playerNumber}, podaj znak ({string.Join("/", allowedSigns)})");
    string sign = GetLowercaseInput();

    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak");
        Console.WriteLine($"Graczu {playerNumber}, podaj POPRAWNY znak ({string.Join("/", allowedSigns)})");
        sign = GetLowercaseInput();
    }

    return sign;
}