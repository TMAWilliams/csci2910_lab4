/**       
 *--------------------------------------------------------------------
 * 	   File name: StateArray.cs
 * 	Project name: csci2910_lab4
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tessa Williams williamstm5@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	 06/7/2023		
 * -------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab4
{
    /***************************************************
     * -Source-
     * Code derived from user jp2code on Stack Overflow: 
     * https://stackoverflow.com/questions/7367529/standardized-us-states-array-and-countries-array
     ***************************************************/
    public class StateArray
    {
        //List to contain all 50 state abbreviations and names as State objects 
        public List<State> states;
        //Adds every state to a list of all states
        public StateArray()
        {
            states = new List<State>(50);
            states.Add(new State("AL", "Alabama"));
            states.Add(new State("AK", "Alaska"));
            states.Add(new State("AZ", "Arizona"));
            states.Add(new State("AR", "Arkansas"));
            states.Add(new State("CA", "California"));
            states.Add(new State("CO", "Colorado"));
            states.Add(new State("CT", "Connecticut"));
            states.Add(new State("DE", "Delaware"));
            states.Add(new State("DC", "District Of Columbia"));
            states.Add(new State("FL", "Florida"));
            states.Add(new State("GA", "Georgia"));
            states.Add(new State("HI", "Hawaii"));
            states.Add(new State("ID", "Idaho"));
            states.Add(new State("IL", "Illinois"));
            states.Add(new State("IN", "Indiana"));
            states.Add(new State("IA", "Iowa"));
            states.Add(new State("KS", "Kansas"));
            states.Add(new State("KY", "Kentucky"));
            states.Add(new State("LA", "Louisiana"));
            states.Add(new State("ME", "Maine"));
            states.Add(new State("MD", "Maryland"));
            states.Add(new State("MA", "Massachusetts"));
            states.Add(new State("MI", "Michigan"));
            states.Add(new State("MN", "Minnesota"));
            states.Add(new State("MS", "Mississippi"));
            states.Add(new State("MO", "Missouri"));
            states.Add(new State("MT", "Montana"));
            states.Add(new State("NE", "Nebraska"));
            states.Add(new State("NV", "Nevada"));
            states.Add(new State("NH", "New Hampshire"));
            states.Add(new State("NJ", "New Jersey"));
            states.Add(new State("NM", "New Mexico"));
            states.Add(new State("NY", "New York"));
            states.Add(new State("NC", "North Carolina"));
            states.Add(new State("ND", "North Dakota"));
            states.Add(new State("OH", "Ohio"));
            states.Add(new State("OK", "Oklahoma"));
            states.Add(new State("OR", "Oregon"));
            states.Add(new State("PA", "Pennsylvania"));
            states.Add(new State("RI", "Rhode Island"));
            states.Add(new State("SC", "South Carolina"));
            states.Add(new State("SD", "South Dakota"));
            states.Add(new State("TN", "Tennessee"));
            states.Add(new State("TX", "Texas"));
            states.Add(new State("UT", "Utah"));
            states.Add(new State("VT", "Vermont"));
            states.Add(new State("VA", "Virginia"));
            states.Add(new State("WA", "Washington"));
            states.Add(new State("WV", "West Virginia"));
            states.Add(new State("WI", "Wisconsin"));
            states.Add(new State("WY", "Wyoming"));
        }

        /// <summary>
        /// searches through the array of states to find a matching abbreviation
        /// </summary>
        /// <param name="abbreviation">state abbreveation to find</param>
        /// <returns>the State object associated with that abbreviation</returns>
        public State RetriveState(string abbreviation)
        {
            State stateFound = states.Find(x => x.Abbreviation == abbreviation);
            return stateFound;
        }
    }
}
