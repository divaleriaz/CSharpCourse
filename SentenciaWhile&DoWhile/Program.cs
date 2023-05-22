internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;

        while(a < 5)
        {
            Console.WriteLine(" repetición de a " + a );
            a++;    
        }

        int b = 0;
        while (b < 100)
        {
            if (b > 10)
                break;

            Console.WriteLine(" repetición de a " + b);
            b++;
        }

        
        {
            string[] travells = new string[5]
            {
            "Mexico",
            "Argentina",
            "Aruba",
            "Paris",
            null
            };

            int index = 0;
            while (index < travells.Length)
            {
                Console.WriteLine(travells[index]);
                index++;
            }
            bool run = false;
            do
            {
                show();

            } while (run);  

            static void show()
            {
                Console.WriteLine("Es lo mismo que lo de arriba");
            } 
        }
    }
    
        


    
}