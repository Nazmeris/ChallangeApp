﻿using ChallangeApp;

var employee = new Employee("John", "Shepard");

Employee employee1 = new Employee("John", "Shepard");

employee.AddGrade(7000);
employee.AddGrade("Adam");
employee.AddGrade(7);
employee.AddGrade("12");
employee.AddGrade(7);

var statistics = employee.GetStatistics();

Console.WriteLine($"Averge:   { statistics.Avarge:N2}");
Console.WriteLine($"Min:   {statistics.Min}");
Console.WriteLine($"Max:   {statistics.Max}");
Console.WriteLine($"Sum:   {statistics.Sum}");

