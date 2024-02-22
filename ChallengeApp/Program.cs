using ChallengeApp;

Console.WriteLine("Witamy w programie ABC do oceny kierownika");
Console.WriteLine("==========================================");


var supervisor = new Supervisor();
Console.WriteLine("");
while(true)
{
    Console.Write("Podaj kolejną wartość oceny:");
    var input = Console.ReadLine();

    if (input == null ||  input == "q")
    {
        break;  
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
    
}

var statistics1 = supervisor.GetStatistics();

Console.WriteLine($"Statistics: Average: {statistics1.Average:N3} Min: {statistics1.Min:N2} Max: {statistics1.Max}");

