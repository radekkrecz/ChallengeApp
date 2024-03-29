﻿using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        const string fileName = "grades.txt";

        public override event GradeAddedDelegate? GradeAdded;
        public event GradeAddedDelegate? GradesCleared;

        public EmployeeInFile() : this("")
        {
        }

        public EmployeeInFile(string name) : this(name,"")
        {

        }

        public EmployeeInFile(string name, string surname) : this(name, surname,0)
        {
        }

        public EmployeeInFile(string name, string surname, int age) : base(name, surname, age)
        { 
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public void ClearGrades()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);

                if (GradesCleared != null)
                {
                    GradesCleared(this, new EventArgs());
                }
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using var writer = File.AppendText(fileName);
                writer.WriteLine(grade);

                if( GradeAdded != null )
                {
                    GradeAdded(this, new EventArgs());
                }
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

            if(File.Exists(fileName))
            {
                int count = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        count++;
                        line = reader.ReadLine();
                    }
                    
                }
            }
            return statistics;  
        }
    }
}
