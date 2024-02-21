using System;

namespace ChallengeApp
{
    public class Employee : Person
    {
        List<float> grades = new();

        public Employee() : this("Jan")
        {
        }

        public Employee(string name) : this(name, "Kowalski")
        {
        }

        public Employee(string name, string surname) : this(name, surname, 18)
        {
        }

        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
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

        public void AddGrade(decimal grade)
        {
            AddGrade((float)grade);

        }

        public void AddGrade(uint grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                AddGrade(value);
            }
            else
            {
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

            return statistics;
        }
    }
}
