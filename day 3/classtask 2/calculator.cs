public class Calculator1
{
    int n1;
    int n2;
 public Calculator1(){}   
 public Calculator1(int _n1, int _n2)
    {
        n1=_n1;
        n2=_n2;
    }   
    public int Sum()
    {
        return n1+n2;
    }
    public int Sub()
    {
        return n1-n2;
    }
    public int Mul()
    {
        return n1*n2;
    }
    public int Dev()
    {
        return n1/n2;
    }
}