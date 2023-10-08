using System;
using System.Collections.Generic;
using myEDB;
partial class Program
{
    static void Main(string[] args)
    {
        EmployeeDatabase database = new EmployeeDatabase();

        Employee employee1 = new Employee(1, "John", "Doe", "Manager", 60000, DateTime.Parse("2022-01-15"));
        Employee employee2 = new Employee(2, "Jane", "Smith", "Developer", 55000, DateTime.Parse("2021-12-10"));
        Employee employee3 = new Employee(3, "Michael", "Johnson", "Designer", 48000, DateTime.Parse("2022-02-28"));
        database.HireEmployee2(employee1);
        database.HireEmployee2(employee2);
        database.HireEmployee2(employee3);
        Employee employee4 = new Employee(1, "Roberto", "Gosh", "Manager", 60000, DateTime.Parse("2022-01-15"));
        Employee employee5 = new Employee(2, "Aron", "Maddison", "Manager", 80000, DateTime.Parse("2022-07-25"));
        Employee employee6 = new Employee(3, "Jeniifer", "Perry", "Developer", 100000, DateTime.Parse("2022-03-07"));
        database.AvailableEmployee(employee4);
        database.AvailableEmployee(employee5);
        database.AvailableEmployee(employee6);

        while (true)
        {
            Console.WriteLine("CEO Database Menu:");
            Console.WriteLine("1. Hire Employee");
            Console.WriteLine("2. Fire Employee");
            Console.WriteLine("3. Find Employee");
            Console.WriteLine("4. Display of hired Employees");
            Console.WriteLine("5. Display of available Employees on the market");
            Console.WriteLine("6. Give a Raise to an Employee");
            Console.WriteLine("7. Reduce an Employee's Salary");
            Console.WriteLine("8. Extend an Employee's Contract");
            Console.WriteLine("9. Quit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Employee ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Position: ");
                    string position = Console.ReadLine();
                    Console.Write("Enter Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter Contract Expiry Date (e.g., yyyy-MM-dd): ");
                    DateTime contractExpiryDate = DateTime.Parse(Console.ReadLine());
                    database.HireEmployee(id, firstName, lastName, position, salary, contractExpiryDate);
                    break;

                case 2:
                    Console.Write("Enter Employee ID to fire: ");
                    int idToFire = int.Parse(Console.ReadLine());
                    database.FireEmployee(idToFire);
                    break;

                case 3:
                    Console.Write("Enter Employee ID to get: ");
                    int idToGet = int.Parse(Console.ReadLine());
                    Employee employee = database.GetEmployee(idToGet);
                    if (employee != null)
                        Console.WriteLine("Employee details: ID: " + employee.Id + ", Name: " + employee.FirstName + " " + employee.LastName + ", Position: " + employee.Position);
                    break;

                case 4:
                    database.DisplayAllEmployees();
                    break;
                case 5:
                    database.DisplayAvailableEmployees();
                    break;
                case 6:
                    Console.Write("Enter Employee ID to give a raise: ");
                    int idToGiveRaise = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount for the raise: ");
                    double raiseAmount = double.Parse(Console.ReadLine());
                    database.GiveRaise(idToGiveRaise, raiseAmount);
                    break;
                case 7:
                    Console.Write("Enter Employee ID to reduce salary: ");
                    int idToReduceSalary = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount to reduce from the salary: ");
                    double reduceAmount = double.Parse(Console.ReadLine());
                    database.ReduceSalary(idToReduceSalary, reduceAmount);
                    break;
                case 8:
                    Console.Write("Enter Employee ID to extend contract: ");
                    int idToExtendContract = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new contract expiry date (yyyy-MM-dd): ");
                    DateTime newExpiryDate = DateTime.Parse(Console.ReadLine());
                    database.ExtendContract(idToExtendContract, newExpiryDate);
                    break;
                case 9:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
