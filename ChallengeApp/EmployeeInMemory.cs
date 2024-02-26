namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        List<float> grades = new();

        public override event GradeAddedDelegate? GradeAdded;

        public EmployeeInMemory() : base()
        {
        }

        public EmployeeInMemory(string name) : base(name)
        {
        }

        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
        }

        public EmployeeInMemory(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public void ClearGrades()
        {
            grades.Clear();
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Grade value is not in range.");
            }
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                AddGrade(value);
            }
            else if (grade.Length == 1)
            {
                AddGrade(grade[0]);
            }
            else
            {
                throw new Exception("Invalid grade value.");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case var g when g >= '0' && g <= '9':
                    AddGrade(grade - '0');
                    break;

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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
