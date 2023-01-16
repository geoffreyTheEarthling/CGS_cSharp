using System;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    abstract class Person
    {
        private string firstname, lastname;
        
        // professional tip: put the constructor first
        public Person(string firstname, string lastname) 
        {
            this.firstname = firstname; // "this" refers to the CURRENT class
            this.lastname = lastname;
        }

        //public string Firstname { get; set; } NO NEED OF GET and SET since we are not...
        //public string Lastname { get; set; }  ...instantiating from this class

        public void Update(string _firstname, string _lastname)
        {
            this.firstname = _firstname; // convention: underscore lets the other programmers know that 
            this.lastname = _lastname;  // the arguments are used to change the value of the variables
        }
        public virtual string toString()
        {
            return this.firstname + " " + this.lastname;
        }
    }
}
