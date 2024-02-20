using ChallengeApp;

Employee employee = new("Jan", "Kowalski");

employee.AddGrade("25");
employee.AddGrade((decimal)60);
employee.AddGrade((double)70);
employee.AddGrade(5);

var statistics1 = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithFor();
var statistics4 = employee.GetStatisticsWithDoWhile();
var statistics5 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Statistics :            Average: {statistics1.Average:N3} Min: {statistics1.Min:N2} Max: {statistics1.Max}");
Console.WriteLine($"Statistics (ForEach):   Average: {statistics2.Average:N3} Min: {statistics2.Min:N2} Max: {statistics2.Max}");
Console.WriteLine($"Statistics (For):       Average: {statistics3.Average:N3} Min: {statistics3.Min:N2} Max: {statistics3.Max}");
Console.WriteLine($"Statistics (DoWhile):   Average: {statistics4.Average:N3} Min: {statistics4.Min:N2} Max: {statistics4.Max}");
Console.WriteLine($"Statistics (While):     Average: {statistics5.Average:N3} Min: {statistics5.Min:N2} Max: {statistics5.Max}");

