using ChallangeApp;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Adam", "Adamowicz", "40");
Employee employee2 = new Employee("Ewa", "Adamowicz", "38");
Employee employee3 = new Employee("Ada", "Adamowicz", "26");

employee1.AddScore(7);
employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(4);
employee1.AddScore(9);

employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(1);
employee2.AddScore(10);
employee2.AddScore(10);

employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(8);
employee3.AddScore(5);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

int maxResult = -1;
Employee? employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}


Console.WriteLine("Najwyższą liczbę ocen otrzymała -" + " " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age +
                 " " + "lat z wynikiem" + " " + employeeWithMaxResult.Result + " " + "punktów.");
