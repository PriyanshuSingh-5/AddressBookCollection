using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    
        public interface EachPerson //To call all the method
        {
              
            void displayPerson();
            void editPerson();
            void deletePerson();
            bool Check(string fname);
            void SearchCityOrState();
        }
    }


