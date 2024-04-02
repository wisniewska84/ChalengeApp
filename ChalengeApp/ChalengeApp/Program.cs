using ChalengeApp;

var employee = new Employee("Szymon", "Kowalski", 30);
employee.AddGrade("Anna");
employee.AddGrade("2000");
employee.AddGrade(101);
employee.AddGrade(8.3d);
employee.AddGrade("2");
employee.AddGrade(-1);
employee.AddGrade(0);
employee.AddGrade(3.33333);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
