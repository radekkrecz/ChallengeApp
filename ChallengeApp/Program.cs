using ChallengeApp;

Employee emp1 = new("Jan", "Kowalski", 29);
Employee emp2 = new("Maria", "Nowakowska", 56);
Employee emp3 = new("Zygmunt", "Siarzewski", 43);

emp1.AddScore(8);
emp2.AddScore(2);
emp3.AddScore(7);

emp1.AddScore(1);
emp2.AddScore(10);
emp3.AddScore(5);

emp1.AddScore(4);
emp2.AddScore(9);
emp3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};


int maxScore = -1;
Employee? employeeWithMaxScore = null;

foreach (var emp in employees)
{
    if(emp.Result > maxScore)
    {
        maxScore = emp.Result;  
        employeeWithMaxScore = emp;
    }
}

Console.WriteLine("Pracownik z najwyższą oceną:");

if (employeeWithMaxScore != null)
    Console.WriteLine(employeeWithMaxScore.Name + " " + employeeWithMaxScore.Surname + " lat " + employeeWithMaxScore.Age + " z oceną " + employeeWithMaxScore.Result);
else
    Console.WriteLine("Brak pracowników.");
