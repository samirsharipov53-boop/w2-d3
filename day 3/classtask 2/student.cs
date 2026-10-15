public class Student1
{
   public int Id ;
   public string Name =null!;
   public int Age ;
   public double Avarage ;
   public Student1(){}
   public Student1(int id, string nam, int age, double av)
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
    public string GetPerfomance()
    {
        if(Avarage <= 4) return "Слабый";
        if(Avarage <= 7) return "Средний";
        else return "Отличник";
    }
}