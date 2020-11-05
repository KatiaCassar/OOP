using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_Worksheet4
{
    class Program
    {
        //1. asking the user to input a number
        //2. create a loop to keep asking the user to input details about the employee
        //3. we will ask the user what to input emplyee? or selesemployee?
        //4. we will store all the emplyees in a list
        //5. we will output all the calculated wages
        //6. the user inputs the idcard of the employee & you need to verify that

        static void Main(string[] args)
        {
            Console.WriteLine("Please input how many emplyees you recruited?");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            List<Employee> myList = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. Sales Employee");
                Console.WriteLine("Input vallue (1 or 2): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");



                switch (choice)
                {
                    case 1:
                        Employee emp = new Employee();

                        Console.WriteLine("ID please");
                        emp.IdCard = Console.ReadLine();

                        Console.WriteLine("Name please");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Salry please");
                        emp.BasePay = Convert.ToDouble(Console.ReadLine());

                        if(myList.IndexOf(emp) == -1) //search for this emp, if index == -1 then not found, if index != -1 then it is found
                        {
                            myList.Add(emp);
                        }

                        Console.WriteLine("");
                        break;

                    case 2:

                        SalesEmployee emp2 = new SalesEmployee();        //this is done because the BasePay attribute is not available in Employee

                        Console.WriteLine("ID please");
                        emp2.IdCard = Console.ReadLine();

                        Console.WriteLine("Name please");
                        emp2.Name = Console.ReadLine();

                        Console.WriteLine("Salary please");
                        emp2.BasePay = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Bonus please");
                        emp2.Bonus = Convert.ToDouble(Console.ReadLine());

                        if (myList.IndexOf(emp2) == -1) //search for this emp, if index == -1 then not found, if index != -1 then it is found
                        {
                            myList.Add(emp2);
                        }

                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("The choice is not valid");
                        Console.WriteLine("");
                        break;
                }
            }

            Console.WriteLine("Press a key to calculate all wages.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

            foreach (Employee employee in myList)
            {
                Console.WriteLine($"Emplyee ({employee.GetType().Name}) {employee.Name} earns ${employee.CalculateTotalPay()}");
            }

            Console.WriteLine("Press a key to terminate.");
            Console.ReadKey();
            
        }
    }
}
