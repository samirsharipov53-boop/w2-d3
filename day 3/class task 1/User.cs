using System.Dynamic;

public class User
{
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string UserName{get; set;}
    public string Pasword{get; set;}
   public void GetInfo()
    {
        System.Console.WriteLine($"{FirstName} {LastName} {UserName}");
    }
    public void Login(string un,string pas)
    {
        if(UserName==un && Pasword==pas) System.Console.WriteLine("Log in sucsses");
        else System.Console.WriteLine("Failed");
    }
}