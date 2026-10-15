public class Student
{
   public int Id ;
   public string Name =null!;
   public int Age ;
   public double Avarage ;
   public Student(){}
   public Student(int id, string nam, int age, double av)
    {
        Id=id;
        Name=nam;
        Age=age;
        Avarage=av;
    }
    public void GetInfo()
    {
    Console.WriteLine($"Id: {Id} Name: {Name} Age: {Age} Avarage Grade: {Avarage}");
    }
    public bool IsExsellent()
    {
        if(Avarage >= 4) return true;
        else return false;
    }
}