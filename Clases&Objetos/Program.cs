internal class Program
{
    private static void Main(string[] args)
    {
        sale sale1 = new sale(1, DateTime.Now);
        Console.WriteLine(sale1.GetInfo());
        sale sale2 = new sale(2, DateTime.Now); 
        Console.WriteLine(sale2.GetInfo()); 
    }

    class sale
    {
        int total;
        DateTime date;

        public sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " Holi crayoli, hoy es: " + date.ToLongDateString();
  
        }
        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        } 

    }
}