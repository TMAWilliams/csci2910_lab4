/**       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: csci2910_lab4
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tessa Williams williamstm5@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	 05/31/2023		
 * -------------------------------------------------------------------
 */
namespace csci2910_lab4
{
    public class Program
    {
        static void Main()
        {
            //Variables
            StateArray states = new StateArray();
            List<Person> people = new List<Person>();
            FileRoot projectRoot = new FileRoot();
            string filePath = projectRoot.GetPath("data.csv");
            string newFilePath = projectRoot.GetPath("data.psv");
            string[] fields = new string[12];
            string[] titles = new string[12];
            string nextLineFromFile;

            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    string header = reader.ReadLine();
                    titles = header.Split(',');
                    //loop until end of file
                    while (reader.Peek() != -1)
                    {
                        nextLineFromFile = reader.ReadLine();
                        fields = nextLineFromFile.Split(',');
                        for (int i = 0; i < fields.Length; i++)
                        {
                            fields[i] = fields[i].Trim('"');
                        }
                        //Find State object based on abbreviation and store it in a State object for later
                        State state = states.RetriveState(fields[6]);
                        //Find elements for address and store them in variables to be used in the construction of an Address object
                        string[] addressParts = fields[3].Split(' ', 2);
                        int addressNum = Convert.ToInt32(addressParts[0]);
                        int zipcode = Convert.ToInt32(fields[7]);
                        Address address = new Address(addressNum, addressParts[1], fields[4], state, zipcode);
                        //Generate Phone number from data
                        Phone phone = new Phone(fields[8]);
                        //Generate Person object from data and add to list of people
                        people.Add(new Person(fields[0], fields[1], address, phone));
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("***There was an error reading the file.***");
                }
            }

            using (StreamWriter writer = new StreamWriter(newFilePath))
            {
                writer.WriteLine($"{titles[0]}|{titles[1]}|{titles[3]}|{titles[8]}");
                foreach (Person person in people)
                {
                    writer.WriteLine(person.ToString());
                }
            }
            Console.WriteLine("CSV file successfully converted to PSV file.");
        }
    }
}