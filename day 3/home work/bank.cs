public class BankAccount
{
    int Id;
    double balance;
    public string? OwnerName;
    bool Isfrozen=true;
    public BankAccount(){}
    public BankAccount(int id, string na, double bal)
    {
        Id=id;
        balance=bal;
        OwnerName=na;
    }
    public void FreezeAccount()
    {
        Isfrozen=false;
    }
    public void UnFreezeAccount()
    {
        Isfrozen=true;
    }
    public void Deposit(double am)
    {
       if(Isfrozen!=false) balance+=am;
    }
    public void Withdraw(double a)
    {
        if(balance<=a && Isfrozen!=false) balance=balance-a;
        else System.Console.WriteLine("!!!EROR!!! <<You coudn't take less than balance>>");
    }
}