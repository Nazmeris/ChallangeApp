using ChallangeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika, żeby zakończyć wciśnij q:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Avarge: {statistics.Avarge}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvargeLatter {statistics.AvargeLatter}");

