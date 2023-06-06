/**       
 *--------------------------------------------------------------------
 * 	   File name: Phone.cs
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
    //Assumption that the phone number is structured the same as a traditional US number (ie. x-xxx-xxx-xxxx)
    public class Phone
    {
        //Fields
        private int _countryCode;
        private int _areaCode;
        private int _exchangeCode;
        private int _lineNumber;
        private long _fullNumber;

        //Properties
        public int CountryCode { get; init; }
        public int AreaCode
        {
            get { return _areaCode; }
            init
            {
                //Validates that area code is three digits
                if (value > 999 || value <= 99)
                {
                    throw new OverflowException();
                }
                _areaCode = value;
            }
        }
        public int ExchangeCode
        {
            get { return _exchangeCode; }
            init
            {
                //Validates that exchange code is three digits
                if (value > 999 || value <= 99)
                {
                    throw new OverflowException();
                }
                _exchangeCode = value;
            }
        }
        public int LineNumber
        {
            get { return _lineNumber; }
            init
            {
                //Validates that line number is four digits
                if (value > 9999 || value <= 999)
                {
                    throw new OverflowException();
                }
                _lineNumber = value;
            }
        }
        public long FullNumber { get; init; }

        //Constructor
        /// <summary>
        /// Splits a string representing a phone number into its various parts(fields)and validates the number.
        /// </summary>
        /// <param name="phoneNumber">string representing the phone number deliminated by hyphens</param>
        public Phone(string phoneNumber)
        {
            string[] partsOfPhoneNumber = phoneNumber.Split('-');
            try
            {
                if (partsOfPhoneNumber.Length == 3)
                {
                    CountryCode = 0;
                    AreaCode = Convert.ToInt32(partsOfPhoneNumber[0]);
                    ExchangeCode = Convert.ToInt32(partsOfPhoneNumber[1]);
                    LineNumber = Convert.ToInt32(partsOfPhoneNumber[2]);
                    FullNumber = Convert.ToInt64(String.Join("", partsOfPhoneNumber));
                }
                else if (partsOfPhoneNumber.Length == 4)
                {
                    CountryCode = Convert.ToInt32(partsOfPhoneNumber[0]);
                    AreaCode = Convert.ToInt32(partsOfPhoneNumber[1]);
                    ExchangeCode = Convert.ToInt32(partsOfPhoneNumber[2]);
                    LineNumber = Convert.ToInt32(partsOfPhoneNumber[3]);
                    FullNumber = Convert.ToInt32(String.Join("", partsOfPhoneNumber));
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch
            {
                Console.WriteLine("*Error* Not a valid phone number.");
            }
        }

        //Methods
        public override string ToString()
        {
            if (CountryCode == 0)
            {
                return $"{AreaCode}-{ExchangeCode}-{LineNumber}";
            }
            else
            {
                return $"{CountryCode}-{AreaCode}-{ExchangeCode}-{LineNumber}";
            }
        }
    }
}
