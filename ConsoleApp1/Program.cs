using ConsoleApp1;
class Program
{
    static void Main()
    {
        Rect r1=new Rect(); //default constructor   
        r1.Length=10;
        r1.Breadth = 20;
        int a=r1.Area();    
        int p=r1.Perimeter();
        Console.WriteLine($"The area of the rectangle is {a} and the perimeter is {p}.");
        
        Rect r2=new Rect(10,20); //parameterized constructor    
        Console.WriteLine($"R2 dimension is {r2.Length}x{r2.Breadth}");

        Rect r3=new Rect(r2);  //copy constructor   
        Console.WriteLine($"R3 dimension is {r3.Length}x{r3.Breadth}");
    }
}

/*

Box: Properties: Length, Breadth, Height
      Behaviors: Volume, Surface Area
 
BankAccount: Properties: AccountNumber, AccountHolderName, Balance
              Behaviors: Deposit, Withdraw, CheckBalance, AccInfo

Distance : Properties: Feet, Inch
           Behaviors: ToMeter, ToCentimeter, ToYard, Sum of 2 Distances

Distance AddDistance(Distance d)
{
        Distance temp=new Distance();
        temp.Feet=this.Feet + d.Feet;
        temp.Inch=this.Inch + d.Inch;
        return temp;    
}
Matrix : Properties:  int[,] a=new int[3,3];    
         Behaviors: Addition, Subtraction
 */