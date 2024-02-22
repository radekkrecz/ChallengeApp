namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        List<float> grades = new();

        public Supervisor() : this("")
        {
        }

        public Supervisor(string name) : this(name, "")
        {
        }

        public Supervisor(string name, string surname) : this(name, surname, 0)
        {
        }

        public Supervisor(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add(grade);
            else
                throw new Exception("Grade value is not in range.");
        }
        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;

                case "6-":
                case "-6":
                    AddGrade(95);
                    break;

                case "5+":
                case "+5":
                    AddGrade(85);
                    break;

                case "5":
                    AddGrade(80);
                    break;

                case "5-":
                case "-5":
                    AddGrade(75);
                    break;

                case "4+":
                case "+4":
                    AddGrade(65);
                    break;

                case "4":
                    AddGrade(60);
                    break;

                case "4-":
                case "-4":
                    AddGrade(55);
                    break;

                case "3+":
                case "+3":
                    AddGrade(45);
                    break;

                case "3":
                    AddGrade(40);
                    break;

                case "3-":
                case "-3":
                    AddGrade(35);
                    break;

                case "2+":
                case "+2":
                    AddGrade(25);
                    break;

                case "2":
                    AddGrade(20);
                    break;

                case "2-":
                case "-2":
                    AddGrade(15);
                    break;

                case "1+":
                case "+1":
                    AddGrade(5);
                    break;

                case "1":
                    AddGrade(0);
                    break;

                default:
                    throw new Exception("Invalid grade value.");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;

                case 'B':
                case 'b':
                    AddGrade(80);
                    break;

                case 'C':
                case 'c':
                    AddGrade(60);
                    break;

                case 'D':
                case 'd':
                    AddGrade(40);
                    break;

                case 'E':
                case 'e':
                    AddGrade(20);
                    break;

                default:
                    throw new Exception("Wrong letter.");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case 100:
                    statistics.AverageLetter = '6';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = '5';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = '4';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = '3';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = '2';
                    break;
                default:
                    statistics.AverageLetter = '1';
                    break;
            }

            return statistics;
        }
    }
}
