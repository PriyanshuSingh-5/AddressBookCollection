using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome in Address book System");
            Address add = new Address();

            //create dictionary to store the details

            Dictionary<string, Address> Dict = new Dictionary<string, Address>();//string is Tkey and AddressBook is TValue.
            bool ProgramIsRunning = true;

            Console.WriteLine("\nHow many address Book you want to create : ");
            int numAddressBooks = Convert.ToInt32(Console.ReadLine()); //store and convert into int using numAdressBooks variable.

            for (int i = 1; i <= numAddressBooks; i++)
            {
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string bookName = Console.ReadLine();
                Address addressBook = new Address(); //creating object of AddressBook class
                Dict.Add(bookName, addressBook); //add element in dictionary
            }
            Console.WriteLine("\nYou have created following Address Books : ");
            foreach (var item in Dict) //var is used and it is store any data type value.
            {
                Console.WriteLine("{0}", item.Key);
            }

            Console.WriteLine("**** Welcome To Address Book System ****");
            Console.WriteLine("\n1.Add Address book  name\n2.Show existing first  Names\n3.Search Person in City or State\n4.Exit "); //Print menu

            Console.Write("Enter Your Choice:- ");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option > 4)
            {
                Console.WriteLine("Plz Enter Valid Option");
                Console.Write("Enter Your Choice:-");
                option = Convert.ToInt32(Console.ReadLine());
            }
            Program addressBook = new Program(); //Create Object AddressBookMain
            string addressBookName = null; // addressBookName empty or null
            switch (option)  //switch Case
            {
                case 1:

                    Console.Write("Enter Address Book System Name:- ");
                    addressBookName = Console.ReadLine();
                    bool person = false;

                    foreach (var person in adressBookList)
                    {
                        if (person.Equals(addressBookName)) //value is present print message
                        {
                            Console.WriteLine("first name  is Already Exist\n Please Enter New Name:");
                            addressBookName = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("first name is valid");
                        }
                    }

                    while (ProgramIsRunning)
                    {
                        Console.WriteLine("\nChoose option to procced further \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Exit");
                        int choice = Convert.ToInt32(Console.ReadLine()); ///store and convert into int using choice variable
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                                string contactName = Console.ReadLine();
                                if (Dict.ContainsKey(contactName))
                                {
                                    Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                                    int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 1; i <= numberOfContacts; i++)
                                    {
                                        AddPerson(Dict[contactName]);
                                    }
                                    Dict[contactName].displayPerson();
                                }
                                else
                                {
                                    Console.WriteLine("No AddressBook exist with name {0}", contactName);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Address Book Name for edit contact");
                                string editcontactName = Console.ReadLine();
                                if (Dict.ContainsKey(editcontactName))
                                {
                                    Dict[editcontactName].editPerson();
                                    Dict[editcontactName].displayPerson();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                                }
                                break;
                            case 3:
                                Console.WriteLine("\nEnter Address Book Name for delete contact");
                                string deleteContact = Console.ReadLine();
                                if (Dict.ContainsKey(deleteContact))
                                {
                                    Dict[deleteContact].deletePerson();
                                    Dict[deleteContact].displayPerson();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                                }
                                break;
                            case 4:
                                Console.WriteLine("\nEnter Address Book Name for display contacts");
                                string displayContactsInAddressBook = Console.ReadLine();
                                Dict[displayContactsInAddressBook].displayPerson();
                                break;


                            case 5:
                                ProgramIsRunning = false;
                                break;
                            default:
                                Console.WriteLine("Please enter valid option");
                                break;
                        }
                    }

                    
                case 2:
                    Console.WriteLine("Details of existing name");
                    foreach (var person in Dict)
                    {
                        Console.WriteLine("existing name details" +person.Equals(firstName));
                    }
                    break;
                case 3:
                    add.SearchCityOrState();
                    break;

                default:
                    break;

            }

        }





        void addContactBook(Address addressBook)
        {
            Console.WriteLine("Enter First Name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email);
        }

    }
}



