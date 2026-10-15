public class Circle
{
    double rad;
    double Pi=3.14159;
    public Circle(double rad)
    {
        this.rad=rad;
    }
    public Circle()
    {
        
    }
    public void SetRadius(double a)
    {
        this.rad=a;
    }
    public double GetRad()
    {
       return rad;
    }
    public double Area()
    {
         
         return Pi*rad*rad;
    }
    public double Diametr()
    {
        return rad*2; 
    }
    public double GetCirclecumf()
    {
        return 2*Pi*rad;
       
    }
}