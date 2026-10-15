public class Diagram{
public class Employee
{
    public string? firsname;
    public string? lasname;
    public int Email;
    public string? Role;
    public string? Password{get;set;}
    
}

public class AcessManager
{
    public AcessManager(){}
    public AcessManager(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
        }
    public void Autentihicate(string email , string Password)
    {
        System.Console.WriteLine($"Hello {email} are you ready to work");
    }
}
}