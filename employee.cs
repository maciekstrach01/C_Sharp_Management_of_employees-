
class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }

    public double Salary { get; set; }
    public DateTime ContractExpiryDate { get; set; }

    public Employee(int id, string firstName, string lastName, string position, double salary, DateTime contractExpiryDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Salary = salary;
        ContractExpiryDate = contractExpiryDate;
    }
    
}

