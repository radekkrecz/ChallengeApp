namespace ChallengeApp
{
    public class Employee
    {
        List<int> score = new ();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return score.Sum();
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
    }
}
