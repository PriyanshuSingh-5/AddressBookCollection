using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{

    public class Address : EachPerson
    {
        List<Person> adressBookList = new List<Person>();//to add details in addressbook

        public void AddContact(string firstName, string lastName, string address, string city, string state, string phoneNumber, string email)
        {
            Person person = new Person(firstName, lastName, city, state, email, phoneNumber);
            adressBookList.Add(person);
        }
        public void displayPerson()  //display details
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }
        public void editPerson()  //edit details
        {
            Console.WriteLine("\n enter First name to edit details:");
            string name = Console.ReadLine();
            foreach (var person in adressBookList)
            {
                if (name.Equals(person.FirstName))
                {
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("#1 Phone Number");
                    Console.WriteLine("#2 Email");
                    Console.WriteLine("#3 City");
                    Console.WriteLine("#4 State");
                    Console.WriteLine("#5 Quit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter new Mobile number:");
                            string mobileNo = Console.ReadLine();
                            person.setPhoneNumber(mobileNo);
                            Console.WriteLine("mobile no. is updated\n");
                            break;
                        case 2:
                            Console.WriteLine("enter new Email-id:");
                            String email = Console.ReadLine();
                            person.setEmail(email);
                            Console.WriteLine("Email-id is updated\n");
                            break;
                        case 3:
                            Console.WriteLine("enter your city");
                            String city = Console.ReadLine();
                            person.setCity(city);
                            break;
                        case 4:
                            Console.WriteLine("enter your state");
                            String state = Console.ReadLine();
                            person.setState(state);
                            person.setState(state);
                            Console.WriteLine("Address is updated\n");
                            break;
                        default:
                            Console.WriteLine("please enter right choice");
                            break;
                    }
                }
            }
        }

        public void deletePerson()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname of the user you want to remove");
            var lastName = Console.ReadLine();
            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
        }



        public bool Check(string fname)  //Check whether same person exist
        {
            int flag = 0;
            foreach (Person person in adressBookList)
            {
                if (person.FirstName.Equals(fname)) //check first name and user input are equal or not
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            return false;
        }
        public void SearchCityOrState()  //SearchRecordCityOrState Record Method
        {


            //public void SearchPersonInStateOrCity()
            //{
            //    Console.WriteLine("Please Enter Your Choice Which You Want To search...");
            //    Console.WriteLine("1. State 2. City");
            //    string option = Console.ReadLine();
            //    int select = Convert.ToInt32(option);
            //    switch (select)
            //    {
            //        case 1:
            //            Console.WriteLine("Please Enter Your First Name : ");
            //            String nameToSearchInState = Console.ReadLine();
            //            foreach (Contacts addressBook in list.FindAll(e => e.FirstName == nameToSearchInState))
            //            {
            //                Console.WriteLine("State of " + nameToSearchInState + " is : " + addressBook.State + "\n");
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Please Enter Your First Name : ");
            //            string searchFirstNameInStateOrCity = Console.ReadLine();
            //            foreach (Contacts addressBook in list.FindAll(e => e.FirstName == searchFirstNameInStateOrCity))
            //            {
            //                Console.WriteLine("City of " + searchFirstNameInStateOrCity + " is : " + addressBook.City + "\n");
            //            }
            //            break;
            //    }

            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                int count = 0;

                Console.WriteLine("Searching contact by City");
                Console.WriteLine("Enter City Name:-");
                string city = Console.ReadLine();

                for (int i = 0; i < adressBookList.Count; i++)
                {
                    if (adressBookList[i].city.Equals(city))
                    {
                        count++;

                        Console.WriteLine("Name:- { adressBookList[i].FirstName} City: { adressBookList[i].city} ");
                    }
                    else
                    {
                        Console.WriteLine("{city} City Name of Record Not Found ");
                    }

                }
            }

           

            else
            {
                int count = 0;
                Console.WriteLine("Search Record by State");
                Console.WriteLine("Enter State Name:-");
                string state = Console.ReadLine();

                for (int i = 0; i < adressBookList.Count; i++)   
                {
                    if (adressBookList[i].state.Equals(state))
                    {
                        count++;
                        Console.WriteLine("Name: { adressBookList[i].FirstName} State: { adressBookList[i].state} ");
                        Console.WriteLine("PhoneNumber: { adressBookList[i].PhoneNumber} State: { adressBookList[i].state} ");

                    }
                    else
                    {
                        Console.WriteLine("{state} State Name of Record Not Found ");
                    }
                }

                Console.WriteLine("\nNumber of contact in the City:- {state} are {count}");
            }
        }
    }
}

