using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string text;
            string name;
            
            List<Person> list = new List<Person>();

            for (; ; )
            {
                Console.WriteLine("Option List ");
                Console.WriteLine("1 For Insert");
                Console.WriteLine("2 For Details");
                Console.WriteLine("3 For Search");
                Console.WriteLine("4 For Delete");
                Console.WriteLine("5 For Exit");
                try
                {
                  choice = int.Parse(Console.ReadLine());
                  if (choice == 1)
                    {
                        Person object1 = new Person();
                        Console.WriteLine("enter details information");
                        Console.WriteLine("Formate: Id,Name,Phone number");

                        text = Console.ReadLine();
                        string[] dummy = text.Split(',');

                        object1.Id = dummy[0];
                        object1.Name = dummy[1];
                        int j;
                        //for (j = 2; j < dummy; j++)
                        //{
                        //    object1.setNumber(dummy[j]);
                        //}
                        for (j = 2; j < dummy.Length;j++)
                        {
                            object1.phoneNumber.Add(dummy[j]);
                        }

                        list.Add(object1);
                    }

                    if (choice == 2)
                    {
                        
                            foreach (Person item in list)
                            {


                                Console.WriteLine("Details Information of the phone Book");
                                Console.WriteLine("Person id is ---" + item.Id);
                                Console.WriteLine("Person name is --- " + item.Name);

                                foreach (string number in item.phoneNumber)
                                {
                                    Console.WriteLine("Person phone numbers are " + number);
                                }
                                Console.WriteLine("");


                            }
                        
                 
                       
                    }
                    if (choice == 3)
                    {
                        string searchId;
                        Console.WriteLine("enter the person id to search");
                        searchId = Console.ReadLine();
                        foreach (Person item in list)
                        {
                            if (searchId == item.Id)
                            {
                                Console.WriteLine("Search Result:");
                                Console.WriteLine("Person id is ---" + item.Id);
                                Console.WriteLine("Person name is--- " + item.Name);
                                foreach (string number in item.phoneNumber)
                                {
                                    Console.WriteLine("Person phone numbers are " + number);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Provided id not match any id from the phone book");
                            }

                        }

                    }
                    if (choice == 4)
                    {
                        string deleteId;
                        int index;
                        Console.WriteLine("enter the person id to delete");
                        deleteId = Console.ReadLine();
                        foreach (Person item in list)
                        {
                            if (deleteId == item.Id)
                            {
                                index = list.IndexOf(item);
                                list.RemoveAt(index);
                                Console.WriteLine("the person information has successfully deleted");
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Provided id not match any id from the phone book");
                            }

                        }
                    }
                    if (choice == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number from the option");
                    }
                }
                catch (Exception e)
                {
                     Console.WriteLine("Enter the right the number from the option ");
                     Console.WriteLine(e.Message);
                }
            }


        }

    }
}
