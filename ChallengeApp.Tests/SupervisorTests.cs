namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void WhenSupervisorCollectAllAllowedStringGrades_ShouldCorrectResult()
        {
            var supervisor  = new Supervisor();

            supervisor.AddGrade("1");   //0
            supervisor.AddGrade("1+");  //5
            supervisor.AddGrade("+1");  //5
            supervisor.AddGrade("-2");  //15
            supervisor.AddGrade("2-");  //15    
            supervisor.AddGrade("2");   //20
            supervisor.AddGrade("2+");  //25
            supervisor.AddGrade("+2");  //25
            supervisor.AddGrade("-3");  //35
            supervisor.AddGrade("3-");  //35
            supervisor.AddGrade("3");   //40
            supervisor.AddGrade("3+");  //45
            supervisor.AddGrade("+3");  //45
            supervisor.AddGrade("-4");  //55
            supervisor.AddGrade("4-");  //55
            supervisor.AddGrade("4");   //60
            supervisor.AddGrade("4+");  //65
            supervisor.AddGrade("+4");  //65
            supervisor.AddGrade("-5");  //75
            supervisor.AddGrade("5-");  //75
            supervisor.AddGrade("5");   //80
            supervisor.AddGrade("5+");  //85
            supervisor.AddGrade("+5");  //85
            supervisor.AddGrade("-6");  //95
            supervisor.AddGrade("6-");  //95
            supervisor.AddGrade("6");   //100

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(0));
                Assert.That(statistics.Max, Is.EqualTo(100));
                Assert.That(statistics.Average, Is.EqualTo(50));
            });
        }

        [Test]
        public void WhenSupervisorCollectOnlyCleanStringGrades_ShouldCorrectResult()
        {
            var supervisor = new Supervisor();

            supervisor.AddGrade("1");   //0
            supervisor.AddGrade("2");   //20
            supervisor.AddGrade("3");   //40
            supervisor.AddGrade("4");   //60
            supervisor.AddGrade("5");   //80
            supervisor.AddGrade("6");   //100

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(0));
                Assert.That(statistics.Max, Is.EqualTo(100));
                Assert.That(statistics.Average, Is.EqualTo(50));
            });
        }

        [Test]
        public void WhenSupervisorCollectOnlyStringGradesWithPlusOnBegin_ShouldCorrectResult()
        {
            var supervisor = new Supervisor();

            supervisor.AddGrade("+1");   //5
            supervisor.AddGrade("+2");   //25
            supervisor.AddGrade("+3");   //45
            supervisor.AddGrade("+4");   //65
            supervisor.AddGrade("+5");   //85

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(5));
                Assert.That(statistics.Max, Is.EqualTo(85));
                Assert.That(statistics.Average, Is.EqualTo(45));
            });
        }

        [Test]
        public void WhenSupervisorCollectOnlyStringGradesWithPlusOnEnd_ShouldCorrectResult()
        {
            var supervisor = new Supervisor();

            supervisor.AddGrade("1+");   //5
            supervisor.AddGrade("2+");   //25
            supervisor.AddGrade("3+");   //45
            supervisor.AddGrade("4+");   //65
            supervisor.AddGrade("5+");   //85

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(5));
                Assert.That(statistics.Max, Is.EqualTo(85));
                Assert.That(statistics.Average, Is.EqualTo(45));
            });
        }

        [Test]
        public void WhenSupervisorCollectOnlyStringGradesWithMinusOnBegin_ShouldCorrectResult()
        {
            var supervisor = new Supervisor();

            supervisor.AddGrade("-2");   //15
            supervisor.AddGrade("-3");   //35
            supervisor.AddGrade("-4");   //55
            supervisor.AddGrade("-5");   //75
            supervisor.AddGrade("-6");   //95

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(15));
                Assert.That(statistics.Max, Is.EqualTo(95));
                Assert.That(statistics.Average, Is.EqualTo(55));
            });
        }

        [Test]
        public void WhenSupervisorCollectOnlyStringGradesWithMinusOnEnd_ShouldCorrectResult()
        {
            var supervisor = new Supervisor();

            supervisor.AddGrade("2-");   //15
            supervisor.AddGrade("3-");   //35
            supervisor.AddGrade("4-");   //55
            supervisor.AddGrade("5-");   //75
            supervisor.AddGrade("6-");   //95

            var statistics = supervisor.GetStatistics();
            Assert.Multiple(() =>
            {
                Assert.That(statistics.Min, Is.EqualTo(15));
                Assert.That(statistics.Max, Is.EqualTo(95));
                Assert.That(statistics.Average, Is.EqualTo(55));
            });
        }    
    }
}
