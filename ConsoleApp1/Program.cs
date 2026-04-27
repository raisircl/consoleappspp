using ConsoleApp1;
class Program
{
    static void Main()
    {
        /*Rect r1=new Rect(); //default constructor   
        r1.Length=10;
        r1.Breadth = 20;
        int a=r1.Area();    
        int p=r1.Perimeter();
        Console.WriteLine($"The area of the rectangle is {a} and the perimeter is {p}.");
        
        Rect r2=new Rect(10,20); //parameterized constructor    
        Console.WriteLine($"R2 dimension is {r2.Length}x{r2.Breadth}");

        Rect r3=new Rect(r2);  //copy constructor   
        Console.WriteLine($"R3 dimension is {r3.Length}x{r3.Breadth}");
        */
        /*Distance d1=new Distance(10, 5);
        Distance d2=new Distance(5, 8);
        Console.WriteLine($"D1={d1}");
        Console.WriteLine($"D2={d2}");
        Distance d3 = new Distance();
        
        d3= d1+d2; 

        Console.WriteLine($"D3={d3}");

        if(d1==d2)
        {
            Console.WriteLine("d1 and d2 are equal" );
        }
        else
        {
            Console.WriteLine("d1 and d2 are not equal");
        }
        */
        Matrix m1 = new Matrix();
        Matrix m2=new Matrix(); 
        Matrix m3=new Matrix(); 
        int i, j;   
        for(i = 0;i<3;i++)
        {
            for (j=0;j<3;j++)  
            {
              Console.WriteLine($"enter element[{i},{j}] for m1:"); 
              m1.a[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine($"enter element[{i},{j}] for m2:");
                m2.a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        m3=m1+m2;
        Matrix m4=new Matrix();
        m4 = m1 + m2 + m3;

        Console.WriteLine($"The sum of m1 and m2 is:\n{m3}");
    }
}

/*

Box: Properties: Length, Breadth, Height
      Behaviors: Volume, Surface Area
      operator overloading : +, -, *, /, ==, !=, >, <, >=, <=
 
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