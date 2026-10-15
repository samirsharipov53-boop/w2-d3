public class Book
{
    string tit=null!;
    string Autor=null!;
    int Year;
    public Book(){}
    public Book(string Tite, string autor, int year){
        Autor=autor;
        Year=year;
        tit=Tite;
        }

    public void Getinfo()
    {
      Console.WriteLine($"Name: {tit}, Writer: {Autor} Writen in: {Year}");  
    }
    public void IsPublished()
    {
        if (Year >= 2010)
        {
            Console.WriteLine("True");
        }
        else Console.WriteLine("False");
    }
};