public class Order
{
    public int OrderNum{get; set;}
    public string ProductName{get; set;}=null!;
    public int Quality{get;set;}
    public double TotalAmount{get;set;}
    public Order(){}
    public Order(int on, string pn, int pq, double Oa)
    {
        OrderNum=on;
        ProductName=pn;
        Quality=pq;
        TotalAmount=Oa;
    }
    public Order( string pn, double Oa)
    {
        ProductName=pn;
        TotalAmount=Oa;
    }
    public Order( string pn, int pq)
    {
        ProductName=pn;
        Quality=pq;
    }
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Product id or number: {OrderNum} ");
        System.Console.WriteLine($"Product Name: {ProductName} ");
        System.Console.WriteLine($"Product Quantity: {Quality} ");
        System.Console.WriteLine($"Total Amount: {TotalAmount} ");
        System.Console.WriteLine();
    }
}