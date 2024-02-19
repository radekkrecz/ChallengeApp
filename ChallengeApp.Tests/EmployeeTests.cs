namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectOnlyPositiveScores_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny", 32);

            emp.AddScore(2);
            emp.AddScore(10);
            emp.AddScore(1);
            emp.AddScore(8);
            emp.AddScore(4);


            var result = emp.Result;

            Assert.That(result, Is.EqualTo(25));

        }
        [Test]
        public void WhenEmployeeCollectOnlyPenaltyScores_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny", 32);

            emp.AddPenaltyScore(8);
            emp.AddPenaltyScore(3);
            emp.AddPenaltyScore(4);
            emp.AddPenaltyScore(5);
            emp.AddPenaltyScore(1);


            var result = emp.Result;

            Assert.That(result, Is.EqualTo(-21));

        }
        [Test]
        public void WhenEmployeeCollectBothTypeOfScores_ShouldCorrectResult()
        {
            var emp = new Employee("Bogus³aw", "Siermi¿ny", 32);

            emp.AddScore(2);
            emp.AddScore(10);
            emp.AddPenaltyScore(5);
            emp.AddScore(7);
            emp.AddPenaltyScore(9);

            var result = emp.Result;

            Assert.That(result, Is.EqualTo(5));
        }
    }
}