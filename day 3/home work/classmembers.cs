public class Clas
{
    int day;
    int month;
    int year;
    public void Date()
    {
        
    }
    public void Date(int day)
    {
        this.day=day;
    }
    public void Date(int day, int month)
    {
        this.day=day;
        this.month=month;
    }
    public void Date(int day, int month, int year)
    {
        this.day=day;
        this.month=month;
        this.year=year;
    }
    public void SetDate(int day, int month, int year)
    {
        this.day=day;
        this.month=month;
        this.year=year;
    }
    public int GetDay()
    {
        System.Console.Write(day);
        return 0;
    }
    public int GetMonth()
    {
        Console.Write("/"+month);
        return 0;
    }
    public int GetYear()
    {
        Console.Write("/"+year);
        return 0;
    }

}