
namespace ChalengeApp.Tests
{
    public class TypeTests
    {
        // typ wartościowy
        [Test]
        public void IntsValueTypeTest()
        {
            // arrange
            int number1 = 2;
            int number2 = 4;
            // act
            // assert
            Assert.AreEqual(number1 + number2, 6);
        }
        [Test]
        public void DoubleValueTypeTest()
        {
            // arrange
            double number1 = 12.5;
            double number2 = 10.5;
            // act
            // assert
            Assert.AreEqual(number1 + number2, 23);
        }
        [Test]
        public void StringValueTypeTest()
        {
            // arrange
            string name1 = "Szymon";
            string name2 = "Szymon";
            // act
            // assert
            Assert.AreEqual(name1, name2);
        }
        // typ referencyjny
        [Test]
        public void ReferenceTypeTest()
        {
            // arrange
            var employee1 = GetEmployee("Szymon", "Kowalski", 30);
            var employee2 = GetEmployee("Szymon", "Nowak", 35);
            // act
            // assert
            Assert.AreNotEqual(employee1, employee2);
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}