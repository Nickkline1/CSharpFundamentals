using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class W1D4User
    {
        //blank construtor
        public W1D4User() { }

        // full constructor
        public W1D4User(string first, string last, int id, DateTime doB)
        {
            FirstName = first;
            LastName = last;
            DoB = doB;
            Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DoB { get; set; }

        //bonus : create a method that returns the full name of the user

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }



    }
}
