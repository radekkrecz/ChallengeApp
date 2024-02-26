namespace ChallengeApp.Tests
{
    public class EmployeeInMemoryTests
    {
        [Test]
        public void WhenEmployeeCollectMaxValueOfGrades_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade(2);
            employee.AddGrade(100);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(100));
        }

        [Test]
        public void WhenEmployeeCollectMinValueOfGrades_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade(2);
            employee.AddGrade(10);
            employee.AddGrade(0);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(0));
        }

        [Test]
        public void WhenEmployeeCollectAllTheSameValueOfGrades_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade(47.5f);
            employee.AddGrade(47.5f);
            employee.AddGrade(47.5f);
            employee.AddGrade(47.5f);
            employee.AddGrade(47.5f);

            var statistics = employee.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(47.5f));
                Assert.That(statistics.Max, Is.EqualTo(47.5f));
                Assert.That(statistics.Average, Is.EqualTo(47.5f));
            });
        }

        [Test]
        public void WhenEmployeeCollectNoValueOfGrade_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            var statistics = employee.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(float.MaxValue));
                Assert.That(statistics.Max, Is.EqualTo(float.MinValue));
                Assert.That(statistics.Average, Is.EqualTo(0));
            });
        }

        [Test]
        public void WhenGradesAreAsStringsAndOneIsOutOfRange_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade("23");
            employee.AddGrade("2");
            employee.AddGrade("78");
            employee.AddGrade("95");

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(95));
        }

        [Test]
        public void WhenGradesAreAsCharsAndOneIsOutOfRange_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade('a');
            employee.AddGrade('C');
            employee.AddGrade('b');
            employee.AddGrade('D');

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(100));
        }

        [Test]
        public void WhenGradesAreAsCharAndOneIsAtMinimumOfRange_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory();

            employee.AddGrade('e');
            employee.AddGrade('A');
            employee.AddGrade('c');
            employee.AddGrade('B');
            employee.AddGrade('D');

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(20));
        }

        [Test]
        public void WhenGradesAreAsCharAndOneIsAtMaximumOfRange_ShouldCorrectResult()
        {
            var employee = new EmployeeInMemory ();

            employee.AddGrade('e');
            employee.AddGrade('A');
            employee.AddGrade('C');
            employee.AddGrade('B');
            employee.AddGrade('D');

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(100));
        }
    }
}