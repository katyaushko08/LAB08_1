using LAB08_1;

Department department = new Department("IT Department");

Employee m1 = new Manager(
    "Ritcher Mitchel",
    new DateTime(1995, 6, 12),
    new DateTime(2019, 5, 6),
    12,
    true
    );

Employee p1 = new Programmer(
    "Alison Krause",
    new DateTime(1990, 6, 12),
    new DateTime(2013, 5, 6),
    Level.MIDDLE
    );

Employee p2 = new Programmer(
    "Alex Donul",
    new DateTime(1995, 6, 12),
    new DateTime(2019, 5, 6),
    Level.SENIOR
    );


Employee w1 = new Worker(
    "Guesip Leonard",
    new DateTime(1990, 6, 12),
    new DateTime(2013, 5, 6),
    23
    );


Employee w2 = new Worker(
    "Guesip Leonard",
    new DateTime(1995, 3, 12),
    new DateTime(2019, 5, 6),
    18
    );

department.AddEmployee(m1);
department.AddEmployee(p1);
department.AddEmployee(p2);
department.AddEmployee(w1);
department.AddEmployee(w2);
department.AddEmployee(m1);

department.PrintEmployees();

Console.WriteLine($"Total employees: {department.CountEmployees()}");
Console.WriteLine($"Workers: {department.CountWorkers()}");
Console.WriteLine($"Programmers: {department.CountProgrammers()}");
Console.WriteLine($"Managers: {department.CountManagers()}");

Console.WriteLine($"Total salary: {department.CalculateTotalSalary()}");
Console.WriteLine($"Average salary: {department.CalculateAverageSalary()}");

Console.WriteLine($"Highest paid: {department.FindHighestPaidEmployee()}");
Console.WriteLine($"Lowest paid: {department.FindLowestPaidEmployee()}");

department.RemoveEmployee(p1.ID);

Console.WriteLine("After removal: ");
department.PrintEmployees();

Console.WriteLine($"Total employees: {department.CountEmployees()}");

Console.WriteLine($"Average salary: {department.CalculateAverageSalary()}");

Employee ? found = department.FindEmployee(p2.ID);
if (found != null)
{
    Console.WriteLine($"Найден {found.Name}");
}
else
{
    Console.WriteLine("Не найден");

}




