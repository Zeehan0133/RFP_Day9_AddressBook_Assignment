using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Address_book
{
    class UC3_UpdateEXsisting_Contact
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public static List<UC3_UpdateEXsisting_Contact> People = new List<UC3_UpdateEXsisting_Contact>();

        public static void NewContact()
        {
            UC3_UpdateEXsisting_Contact person = new UC3_UpdateEXsisting_Contact();

            Console.Write("Enter First Name: ");
            person.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            person.zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phonenumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();


            People.Add(person);
        }


        public static void PrintingDetails(UC3_UpdateEXsisting_Contact person)
        {
            Console.WriteLine("First Name: " + person.firstname);
            Console.WriteLine("Last Name: " + person.lastname);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip Code: " + person.zipcode);
            Console.WriteLine("Phone Number: " + person.phonenumber);
            Console.WriteLine("Email ID: " + person.email);
            Console.WriteLine("-------------------------------------------");
        }

        public static void ListAllContacts()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintingDetails(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }

        public static void Update()
        {
            Console.WriteLine("Press 1 If you want to edit any Contact in the Address Book");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the First Name of the Person U want to update");
                    string firstname = Console.ReadLine();
                    UC3_UpdateEXsisting_Contact person = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
                    if (person == null)
                    {
                        Console.WriteLine("That person U entered is not found");
                    }

                    Console.WriteLine("Are you sure you want to edit the person details from your address book? Enter --> (Y/N)");
                    PrintingDetails(person);
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Press 1 if u want to edit the LastName");
                        Console.WriteLine("Press 2 if u want to edit the Address");
                        Console.WriteLine("Press 3 if u want to edit the City");
                        Console.WriteLine("Press 4 if u want to edit the State");
                        Console.WriteLine("Press 5 if u want to edit the Zip Code");
                        Console.WriteLine("Press 6 if u want to edit the Phone Number");
                        Console.WriteLine("Press 7 if u want to edit the Email Id");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter New LastName; ");
                                person.lastname = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Last Name: " + person.lastname);
                                break;
                            case 2:
                                Console.WriteLine("Enter New Address; ");
                                person.address = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Address: " + person.address);
                                break;
                            case 3:
                                Console.WriteLine("Enter New City: ");
                                person.city = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("City: " + person.city);
                                break;
                            case 4:
                                Console.WriteLine("Enter New State: ");
                                person.state = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("MobileNumber: " + person.state);
                                break;
                            case 5:
                                Console.WriteLine("Enter New ZipCode: ");
                                person.zipcode = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("ZipCode: " + person.zipcode);
                                break;
                            case 6:
                                Console.WriteLine("Enter New PhoneNumber: ");
                                person.phonenumber = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("PhoneNumber: " + person.phonenumber);
                                break;
                            case 7:
                                Console.WriteLine("Enter New Email ID: ");
                                person.email = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Email Id: " + person.email);
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Console.WriteLine("OKK. Press any key to continue.");
                    }
                    ListAllContacts();
                    break;
                default:
                    Console.WriteLine("Thanku!!!");
                    break;
                
                    
            }
        }
    }
}
