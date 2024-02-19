using ChallengeApp;

Employee employee = new("Jan", "Kowalski");

employee.AddGrade(9);
employee.AddGrade(1);
employee.AddGrade(7);
employee.AddGrade(5);

var statistics1 = employee.GetStatistics();

Console.WriteLine($"Statistics for {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics1.Average:N3}");
Console.WriteLine($"Min: {statistics1.Min:N2}");
Console.WriteLine($"Max: {statistics1.Max}");

