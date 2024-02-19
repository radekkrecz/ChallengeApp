namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectMaxValueOfGrades_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny");

            emp.AddGrade(2);
            emp.AddGrade(10);
            emp.AddGrade(1);
            emp.AddGrade(8);
            emp.AddGrade(4);

            var statistics = emp.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(10));
        }
        [Test]
        public void WhenEmployeeCollectMinValueOfGrades_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny");

            emp.AddGrade(2);
            emp.AddGrade(10);
            emp.AddGrade(1);
            emp.AddGrade(8);
            emp.AddGrade(4);

            var statistics = emp.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(1));
        }
        [Test]
        public void WhenEmployeeCollectAllTheSameValueOfGrades_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny");

            emp.AddGrade(4.5f);
            emp.AddGrade(4.5f);
            emp.AddGrade(4.5f);
            emp.AddGrade(4.5f);
            emp.AddGrade(4.5f);

            var statistics = emp.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(4.5f));
                Assert.That(statistics.Max, Is.EqualTo(4.5f));
                Assert.That(statistics.Average, Is.EqualTo(4.5f));
            });
        }

        [Test]
        public void WhenEmployeeCollectNoValueOfGrade_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny");

            var statistics = emp.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(float.MaxValue));
                Assert.That(statistics.Max, Is.EqualTo(float.MinValue));
                Assert.That(statistics.Average, Is.EqualTo(float.NaN));
            });
        }
    }
}