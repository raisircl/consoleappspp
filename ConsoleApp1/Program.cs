using ConsoleApp1;
class Program
{
    static void Main()
    {
        Rect r1=new Rect();
        r1.Length=10;
        r1.Breadth = 20;
        int a=r1.Area();    
        int p=r1.Perimeter();
        Console.WriteLine($"The area of the rectangle is {a} and the perimeter is {p}.");
    }
}

/*

Box: Properties: Length, Breadth, Height
      Behaviors: Volume, Surface Area
 
BankAccount: Properties: AccountNumber, AccountHolderName, Balance
              Behaviors: Deposit, Withdraw, CheckBalance, AccInfo

 
 */