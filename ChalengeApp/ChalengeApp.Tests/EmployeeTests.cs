namespace ChalengeApp.Tests
{    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectNegativeRatings_SholudReturnCorrectSumOfResult()
        {
            // arrage
            var employee = new Employee("Szymon", "Kowalski", 30);
            employee.AddScore(-5);
            employee.AddScore(-6);
            employee.AddScore(-1);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(-12, result);
        }
        [Test]
        public void WhenEmployeeCollectPositiveRatings_ShouldReturnCorrectSumOfResult()
        {
            // arrage 
            var employee = new Employee("Emilia", "Nowak", 35);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(1);
            //act
            var result = employee.Result;
            // assert
            Assert.AreEqual(12, result);
        }
        [Test]
        public void WhenEmployeeCollectMixedRatings_ShouldReturnCorrectSumOfResult()
        {
            // arrange
            var employee = new Employee("Gabriela", "Sikora", 33);
            employee.AddScore(-5);
            employee.AddScore(-6);
            employee.AddScore(11);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(0, result);
        }
    }
}