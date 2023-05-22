internal class Program
{
    private static void Main(string[] args)
    {
        bool areYouSleepy = true;
        bool youHaveToWork = false;

        if (areYouSleepy && youHaveToWork)
        {
            Console.WriteLine("Duermes");
        }
       
        else
        {
            Console.WriteLine("No duermes");
        }
        static bool isAWeekend(string motive, int hour = 0)
        {
            if (motive == "es fin de semana" && hour > 23 && hour < 8)
            {
                return true;
            }
            else if (motive == "Acabe todos mis pendientes")
            {
                return true;
            }
            else 
        }
       

        


    }
}