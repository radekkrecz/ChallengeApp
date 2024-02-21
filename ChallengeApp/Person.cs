﻿namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;  
            Age = age;  
        }
    }
}
