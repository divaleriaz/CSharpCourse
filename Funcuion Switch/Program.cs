internal class Program
{
    private static void Main(string[] args)
    {
        int opcion = 7;
        
        switch (opcion)
        {
            case 1:
                Console.WriteLine("A Miguel le encanta la putería");
                break;
            case 2:
                Console.WriteLine("Miguel ama tragar");
                break;
            case 3:
                Console.WriteLine("Miguel ama los gatos");
                break;
            case 4:
            case 5:
                Console.WriteLine("El man quiere lokiar");
                break;

            case < 0:
            case > 100:
                Console.WriteLine("Fuera de rango");
                break;

            case > 6 and < 10:
                 Console.WriteLine("Es un tragon");
                break;
            
            default: 
                Console.WriteLine("Todas las anteriores");
                break;

        }
        
    }
}