using System;

namespace Day6_Address_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Development :");
             UC1_Person.Person();


            UC2_Add_Contacts.NewContact();
            UC2_Add_Contacts.ListPeople();
            UC2_Add_Contacts.AddNew();

            UC3_UpdateEXsisting_Contact.NewContact();
            UC3_UpdateEXsisting_Contact.ListAllContacts();
            UC3_UpdateEXsisting_Contact.Update();

            UC4_DeleteContact.NewContact();
            UC4_DeleteContact.ListContacts();
            UC4_DeleteContact.RemovePerson();

            

            Console.ReadLine();

        }
    }
}
