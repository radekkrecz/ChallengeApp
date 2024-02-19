namespace ChallengeApp
{
    public class Employee
    {
        List<int> score = new();
        List<int> penaltyScore = new();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return ( score.Sum() - penaltyScore.Sum() );
            }
        }

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
        public void AddPenaltyScore(int score)
        {
            this.penaltyScore.Add(score);
        }
    }
}
