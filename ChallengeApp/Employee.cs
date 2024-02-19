namespace ChallengeApp
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

        public void AddGrade(float grade)
        {
            grades.Add(grade);
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
