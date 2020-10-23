using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1intoToOOP
{
    //class:    is a blueprint (template) tahte defined an entity structure. An entity (usually) represents a real-life
    //          model object which is described using characteristics (use Pascal casing for public members/objects)
    //field:    is a variable which describe something about the model/object (use camel casing)
    //property: is (usually) declared as public and controls the accebility to the field

    class Person  //an example of a class
    {
        private string idCardNo;     //when you declaire something in a class, it is by default Private
        string name;    //an example of a field
        string surname;

        //fields cannot be accessed from outside the class directly, thus we need to create a property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string IdCard
        {
            get { return idCardNo; }
            set  
            {
                switch (value.ToString().Length)
                {
                    case 5:
                        idCardNo = "00" + value;
                        break;
                    case 6:
                        idCardNo = "0" + value;
                        break;
                    case 7:
                        idCardNo = value.ToString();
                        break;
                }
                idCardNo = value.ToString().ToUpper();//ensuring that all the saved id num are saved as a string and with
                //a capital letter, this is done to avoid any ambiguis situations
            }
        }

        public string FullName      //read only property
        {
            get { return Name + " " + Surname; }
        }

        //taking a shortcut (if we know that we do not need any particular implimenattion for this particlular member)
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public DateTime DateofBirth { get; set; }


        public int CalculateAge()
        {
            return DateTime.Today.Year - DateofBirth.Year;
        }

        //this will put a "," after each word of the adress, given by the user
        public string DelimitAddress(char c)
        {
            string[] delimitedAddress = Address.Split(new char[] { ' ' });
            string output = "";
            foreach(string s in delimitedAddress)
            {
                output += s + c + " ";
            }
            return output.Remove(output.Length-2);
        }
    }
}