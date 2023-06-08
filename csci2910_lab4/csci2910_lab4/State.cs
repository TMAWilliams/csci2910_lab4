/**       
 *--------------------------------------------------------------------
 * 	   File name: State.cs
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
    public class State
    {
        //Fields
        private string _abbreviation;
        private string _fullName;

        //Properties
        public string Abbreviation { get; init; }
        public string FullName { get; init; }

        //Constructor
        public State(string abbreviation, string fullname)
        {
            Abbreviation = abbreviation;
            FullName = fullname;
        }

        //Method
        public override string ToString()
        {
            return $"{FullName} - {Abbreviation}";
        }
    }
}
