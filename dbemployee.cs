
namespace myEDB
{
class EmployeeDatabase
{
    private Dictionary<int, Employee> employees;
    private Dictionary<int, Employee> availableemployees;

    public EmployeeDatabase()
    {
        employees = new Dictionary<int, Employee>();
        availableemployees = new Dictionary<int, Employee>();
    }

  
    public void HireEmployee(int id, string firstName, string lastName, string position, double salary, DateTime contractExpiryDate)
    {
        Employee employee = new Employee(id, firstName, lastName, position, salary, contractExpiryDate);

        employees[id] = employee;
        Console.WriteLine("Employee hired successfully.");
    }

    public void HireEmployee2(Employee employee)
    {
        employees[employee.Id] = employee;
        //Console.WriteLine("Employee hired successfully.");
    }

        public void AvailableEmployee(Employee employee)
    {
        availableemployees[employee.Id] = employee;
        //Console.WriteLine("Employee hired successfully.");
    }



    public void FireEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            employees.Remove(id);
            Console.WriteLine("Employee with ID " + id + " has been fired.");
        }
        else
        {
            Console.WriteLine("Employee with ID " + id + " not found.");
        }
    }

    public Employee GetEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            return employees[id];
        }
        else
        {
            //throw new ArgumentException($"Employee with ID {id} not found.");
            Console.WriteLine("Employee with ID " + id + " not found.");
            return null;
        }
    }

    public void DisplayAllEmployees()
    {
        Console.WriteLine("List of all employees:");
        foreach (var employee in employees.Values)
        {
            Console.WriteLine("ID: " + employee.Id + ", Name: " + employee.FirstName + " " + employee.LastName + ", Position: " + employee.Position);
        }
    }

        public void DisplayAvailableEmployees()
    {
        Console.WriteLine("List of available employees:");
        foreach (var employee in availableemployees.Values)
        {
            Console.WriteLine("ID: " + employee.Id + ", Name: " + employee.FirstName + " " + employee.LastName + ", Position: " + employee.Position);
        }
    }

    public void GiveRaise(int id, double amount)
    {
        if (employees.ContainsKey(id))
        {
            employees[id].Salary += amount;
            Console.WriteLine("Raise given successfully to Employee with ID " + id + ".");
        }
        else
        {
            Console.WriteLine("Employee with ID " + id + " not found.");
        }
    }

    public void ReduceSalary(int id, double amount)
    {
        if (employees.ContainsKey(id))
        {
            employees[id].Salary -= amount;
            Console.WriteLine("Salary reduced successfully for Employee with ID " + id + ".");
        }
        else
        {
            Console.WriteLine("Employee with ID " + id + " not found.");
        }
    }

    public void ExtendContract(int id, DateTime newExpiryDate)
    {
        if (employees.ContainsKey(id))
        {
            employees[id].ContractExpiryDate = newExpiryDate;
            Console.WriteLine("Contract extended successfully for Employee with ID " + id + ".");
        }
        else
        {
            Console.WriteLine("Employee with ID " + id + " not found.");
        }
    }
}
}