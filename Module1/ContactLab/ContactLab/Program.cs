using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLab
{
    class Program
    {
        //static
        static List<Contact> contactList = new List<Contact>();
        
        static void Main(string[] args)
        {
            do
            {
                Contact contact = new Contact();
                Console.WriteLine("1 Add\n" +
                    "2 Display\n" +
                    "3 Edit\n" +
                    "Contact\n" +
                    "4 Show All\n" +
                    "5 Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddContact(contact);
                            break;
                        case 2:
                            DisplayContact();
                            break;
                        case 3:
                            EditContact(contact);
                            break;
                        case 4:
                            ShowAllContact(contact);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

        private static void ShowAllContact(Contact contact)
        {
            foreach (var item in contactList)
            {
                Console.WriteLine(item);
            }
        }

        private static void EditContact(Contact contact)
        {
            Console.WriteLine("Enter Contact No");
            contact.ContactNo = int.Parse(Console.ReadLine());
            var existingContact = contactList.Find(e => e.ContactNo == contact.ContactNo);
            if (existingContact == null)
            {
                Console.WriteLine("Contact Not Found");
            }
            else
            {
                Console.WriteLine("Enter New Contact Name");
                existingContact.ContactName = Console.ReadLine();
                 

                Console.WriteLine("Enter cell no");
                existingContact.CellNo = Console.ReadLine();

                Console.WriteLine("Contact Upadated Successfully");
                
            }
        }
        private static void DisplayContact()
        {
            Console.WriteLine("Enter Contact Id, Contact Name or cell Number");
            string input = Console.ReadLine();
            List<Contact> cntlist = null;
            if (int.TryParse(input, out int contactNo))
            {
                cntlist = contactList.FindAll(e => e.ContactNo == contactNo);
                foreach (var item in cntlist)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                if (long.TryParse(input, out long cellNo) && input.Length == 0)
                {
                    cntlist = contactList.FindAll(e => e.CellNo == input);
                    
                }
                else
                {
                    input = input.ToLower();
                    cntlist = contactList.FindAll(e => e.ContactName.ToLower() == input);
                    Console.WriteLine(cntlist);
                }
            }
            
        }


        public static void AddContact(Contact contact)
        {
           
            Console.WriteLine("Enter Contact Number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int contactNo))
            {
                contact.ContactNo = contactNo;
                Console.WriteLine("Enter Contact Name");
                input = Console.ReadLine();
                contact.ContactName = input;

                Console.WriteLine("Enter Cell No");
                input = Console.ReadLine();
                if (long.TryParse(input, out long cellNo) && input.Length == 10)
                {
                    contact.CellNo = input;
                    contactList.Add(contact);
                    Console.WriteLine("Contact Added Successfully");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
