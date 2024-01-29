// Zadanie domowe dzień 6
using ChalengeApp;

Employee employee1 = new Employee("Szymon", "Kowalski", 30);
Employee employee2 = new Employee("Emilia", "Nowak", 35);
Employee employee3 = new Employee("Gabriela", "Sikora", 33);

employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(10);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.maxResult > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.maxResult;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą punktów: " + employeeWithMaxResult.Name + " " + 
    employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " " + " lata " + "z wynikiem " + " " + maxResult);

