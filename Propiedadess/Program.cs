internal class Program
{
    private static void Main(string[] args)
    {
        sale mysale = new sale(100, DateTime.Now);
        mysale.Total = -10000;
        Console.WriteLine(mysale.Total);
        Console.WriteLine(mysale.Date);

    }

     public class sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get
            {

                if (date.Date == new DateTime(2023, 5, 15))
                {
                    return null;
                }
                else
                {
                    return date.ToLongDateString();
                }
            }
            set 
            {
               
                date = DateTime.Parse(value);       
                
            }
        }

        public int Total 
        {
            get 
            
            { 
                return total; 
            }
            set
            {
                if (value < 0) 
                    value = 0;
                total = value;
             
            }
        }

        public sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        

    }
}
    
