/**       
 *--------------------------------------------------------------------
 * 	   File name: Person.cs
 * 	Project name: csci2910_lab4
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tessa Williams williamstm5@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	 06/04/2023		
 * -------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab4
{
    public class Person
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private Address _address;
        private Phone _phone;

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }

        //Constructors
        /// <summary>
        /// Parameterized constructor that generates a person based on passed in arguments
        /// </summary>
        /// <param name="firstName">string - first name of person</param>
        /// <param name="lastName">string - last name of person</param>
        /// <param name="address">Address - an object containing the person's address information</param>
        /// <param name="phone">Phone - an object containing the person's phone information</param>
        public Person(string firstName, string lastName, Address address, Phone phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        //Method
        public override string ToString()
        {
            string msg = $"{FirstName}|{LastName}|{Address}|{Phone}";
            return msg;
        }
    }
}
