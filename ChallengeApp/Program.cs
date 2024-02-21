using ChallengeApp;

Console.WriteLine("Witamy w programie ABC do oceny pracownika");
Console.WriteLine("==========================================");


var employee = new Employee("", "");
Console.WriteLine("");
while(true)
{
    Console.WriteLine("Podaj kolejną wartość oceny:");
    var input = Console.ReadLine();
    if (input == null ||  input == "q")
    {
        break;  
    }
    try
    {
        if(input.Length == 1)
        {
            employee.AddGrade(input.First());
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
    
}

var statistics1 = employee.GetStatistics();

Console.WriteLine($"Statistics: Average: {statistics1.Average:N3} Min: {statistics1.Min:N2} Max: {statistics1.Max}");

