using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    public class EachPerson
    {
        public interface IPerson //To call all the methods
        {
            void addPerson();  
            void displayPerson();
            void editPerson();
            void deletePerson();
        }
    }
}
