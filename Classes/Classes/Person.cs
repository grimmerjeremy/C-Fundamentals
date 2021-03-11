using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{
    
    public class Person
    {
        public string FullName 
        { 
            get 
            {
                return $"{FirstName} {LastName}";
            } 
        }
        public string FirstName { get; set; }

        private string _lastName; 
        public string LastName
        { 
            get { return _lastName; }
            set { _lastName = value; }
        }

        //Using date of birth to determin age.
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
                //hover over var to see that the number defaults to a double. Add an m at the end of a number to change it to a decimal.
                var number = 6.6;
            }
        }

        public Vehicle Transport { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

    }
}
