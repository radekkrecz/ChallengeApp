using ChallengeApp;

Console.WriteLine("Witamy w programie ABC do oceny kierownika");
Console.WriteLine("==========================================");


var employee = new EmployeeInMemory();

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano ocenę pracownika");
}

Console.WriteLine("");

employee.AddGrade(45);
employee.AddGrade('A');


employee.GradeAdded -= EmployeeGradeAdded;

//while(true)
//{
//    Console.Write("Podaj kolejną wartość oceny:");
//    var input = Console.ReadLine();

//    if (input == null ||  input == "q")
//    {
//        break;  
//    }
//    else if(input == "c")
//    {
//        Console.Write("\nCzy napewno chesz skasować wszystkie oceny pracownika?");
//        var confimration = Console.ReadLine();

//        if(confimration != null && confimration.ToLower() == "y")
//        {
//            employee.ClearGrades();
//            Console.WriteLine("Oceny pracownika zostały skasowane\n");
//        }
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception ex) 
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//var statistics1 = employee.GetStatistics();

//Console.WriteLine($"Statistics: Average: {statistics1.Average:N3} Min: {statistics1.Min:N2} Max: {statistics1.Max}");

