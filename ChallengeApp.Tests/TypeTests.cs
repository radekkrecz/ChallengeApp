using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void WhenIntegersAreEqual_ShouldReturnCorrectResult()
        {
            int number1 = 12;
            int number2 = 12;

            Assert.That(number1, Is.EqualTo(number2));

        }

        [Test]
        public void WhenFloatsAreEqual_ShouldReturnCorrectResult()
        {
            float number1 = 390.71f;
            float number2 = 390.71f;

            Assert.That(number1, Is.EqualTo(number2));

        }

        [Test]
        public void WhenStringsAreEqual_ShouldReturnCorrectResult()
        {
            string property1 = "height";
            string property2 = "height";

            Assert.That(property1, Is.EqualTo(property2));

        }

        [Test]
        public void WhenNamesOfEmployeesAreEqual_ShouldReturnCorrectResult()
        {
            Employee emp1 = GetEmployee("Bożena", "Kosiba", 19);
            Employee emp2 = GetEmployee("Bożena", "Pawlak", 49);

            Assert.That(emp1.Name, Is.EqualTo(emp2.Name));
        }

        [Test]
        public void WhenAgesOfEmployeesAreNotEqual_ShouldReturnCorrectResult()
        {
            Employee emp1 = GetEmployee("Bożena", "Kosiba", 19);
            Employee emp2 = GetEmployee("Bożena", "Pawlak", 49);

            Assert.That(emp1.Age, Is.Not.EqualTo(emp2.Age));
        }

        [Test]
        public void WhenTwoObjectsOfEmployeesAreNotEqual_ShouldReturnCorrectResult()
        {
            Employee emp1 = GetEmployee("Bożena", "Kosiba", 19);
            Employee emp2 = GetEmployee("Bożena", "Pawlak", 49);

            Assert.That(emp1, Is.Not.EqualTo(emp2));
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
