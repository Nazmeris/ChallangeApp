// Zadanie dzień 4.
var name = "Ewa";
var sex = "F";
var age = 67;

if (age >= 30)
{
    if (sex == "M")
    {
        Console.WriteLine("Mężczyzna powyżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
else
{
    if (sex == "M")
    {
        Console.WriteLine("Mężczyzna poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
Console.WriteLine($"{name}, lat {age}.");
if (age >= 18)
{
    if (sex == "M")
    {
        Console.WriteLine("Pełnotetni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletnia Kobieta");
    }
}
else
{
    if (sex == "M")
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletnia Kobieta");
    }
}
