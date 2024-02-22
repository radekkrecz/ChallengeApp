using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        const string fileName = "grades.txt";

        public EmployeeInFile() : base() 
        {
        }

        public EmployeeInFile(string name) : base(name)
        {
        }

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public EmployeeInFile(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public void ClearGrades()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using var writer = File.AppendText(fileName);
                writer.WriteLine(grade);
            }
            else
                throw new Exception("Grade value is not in range.");
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

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            if(File.Exists(fileName))
            {
                int count = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    do
                    {
                        var number = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        count++;
                        line = reader.ReadLine();
                    }
                    while (line != null);
                }

                if(count > 0)
                {
                    statistics.Average /= count;

                    switch (statistics.Average)
                    {
                        case var average when average >= 80:
                            statistics.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            statistics.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            statistics.AverageLetter = 'C';
                            break;
                        case var average when average >= 20:
                            statistics.AverageLetter = 'D';
                            break;
                        default:
                            statistics.AverageLetter = 'E';
                            break;
                    }
                }
            }
            return statistics;  
        }
    }
}
