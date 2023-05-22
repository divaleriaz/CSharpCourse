internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;  
        int b = 2;

        Show();
        
        Sum(1,2);   
        Sum(5,4);

        int m = (2*4);
        Console.WriteLine(m); 
    }
     static int mult(int num1, int num2)
    { 
        return num1 * num2;

    }

    static void Sum(int num1, int num2)
    {
        int num3 = num1 + num2; 
        Console.WriteLine(num3);    
    }
    static void Show()
    {
        Console.WriteLine("Hey these are my first steps");
    }
   
}
