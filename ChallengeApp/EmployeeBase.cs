namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public delegate void  GradeAddedDelegate(object sender, EventArgs e);
        
        public event GradeAddedDelegate? GradeAdded;

        public EmployeeBase() : this("")
        {
        }

        public EmployeeBase(string name) : this(name, "")
        {
        }

        public EmployeeBase(string name, string surname) : this(name, surname, 0)
        {
        }

        public EmployeeBase(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        protected void InvokeGradeAddedEvent()
        {
            if(GradeAdded != null) 
            {
                GradeAdded(this, EventArgs.Empty);  
            }
        }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
