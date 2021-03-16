using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace W1D5ChallengeClassAndProperties
{

    public class User()
    {
    
    
     public User(string firstName, string lastName, int IDNumber, DateTime birthDate)
    {
        FirstName = firstName;
        LastNmae = lastName;
        ID = IDNumber;
        BirthDate = birthDate;
    }



    public DateTime DateOfBirth { get; set; }
    public int Age
    {
        get
        {
            TimeSpan ageSpan = DateTime.Now - DateOfBirth;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return yearsOfAge;
        }
    }
}
