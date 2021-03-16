using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D5ChallengeClassAndProperties
{
    class W1D5WithClassUser
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int IdNumber { get; }
        public DateTime DateOfBirth;


        public W1D5WithClassUser(string firstName, string lastName, int IDNumber, DateTime birthDate)
        {
            FirstName = firstName;
            FirstName = lastName;
            IdNumber = IDNumber;
            DateOfBirth = birthDate;
        }



    }


}
