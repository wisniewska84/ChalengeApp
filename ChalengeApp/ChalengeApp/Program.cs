using ChalengeApp;

var employee = new Employee("Szymon", "Kowalski", 30);
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(7);
employee.AddGrade(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
