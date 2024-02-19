﻿namespace ChallengeApp
{
    public class Employee
    {
        List<float> grades = new();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add((float)grade);
            else
                Console.WriteLine("Invalid grade value!");
        }
        public void AddGrade(decimal grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add((float)grade);
            else
                Console.WriteLine("Invalid grade value!");
        }
        public void AddGrade(uint grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add(grade);
            else
                Console.WriteLine("Invalid grade value!");
        }
        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add(grade);
            else
                Console.WriteLine("Invalid grade value!");
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                grades.Add(grade);
            else
                Console.WriteLine("Invalid grade value!");
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                AddGrade(value);
            }
            else
            {
                Console.WriteLine("Grade string is not a number!");
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

            return statistics;
        }
    }
}
