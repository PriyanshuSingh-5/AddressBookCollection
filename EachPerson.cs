using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class EachPerson
    {
        public interface Person
        {
            void addPerson();  
            void displayPerson();
            void editPerson();
            void deletePerson();
        }
    }
}
