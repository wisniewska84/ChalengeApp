
namespace ChalengeApp.Tests
{
    public class Employee1Tests
    {
        [Test]
        public void CheckMethodGetStatisticsMax()
        {
            //arrange 
            var employee = new Employee("Szymon", "Kowalski", 30);
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(1);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(7, statistics.Max);
        }
        [Test]
        public void CheckMethodGetStatisticsMin()
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalski", 31);
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(-6);
            employee.AddGrade(7);
            employee.AddGrade(1);
            // act
            var statistics = employee.GetStatistics();
            // assert 
            Assert.AreEqual(-6, statistics.Min);
        }
        [Test]
        public void CheckMethodGetStatisticsAverage() 
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalski", 32);
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(0);
            employee.AddGrade(7);
            employee.AddGrade(1);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(3, statistics.Average);
        }
    }
}
