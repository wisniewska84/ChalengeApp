﻿
namespace ChalengeApp
{
    public class Employee
    {
        private List<int> rating = new List<int>(); 
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int maxResult
        {
            get
            {
                return this.rating.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.rating.Add(number);
        }
    }
}


