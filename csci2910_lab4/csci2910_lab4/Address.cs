/**       
 *--------------------------------------------------------------------
 * 	   File name: Address.cs
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
    public class Address
    {
        //Fields
        private int _number;
        private string _street;
        private string _city;
        private State _state;
        private int _zipcode;

        //Properties
        public int Number { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public State State { get; init; }
        public int Zipcode { get; init; }

        //Constructor
        public Address(int number, string street, string city, State state, int zipcode)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
        }

        //Method
        public override string ToString()
        {
            return $"{Number} {Street} , {City} , {State.Abbreviation} {Zipcode}";
        }
    }
}
