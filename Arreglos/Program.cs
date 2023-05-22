internal class Program
{
    private static void Main(string[] args)
    {
        string[] travells = new string[4]
        {
            "Mexico",
            "Argentina",
            "Aruba",
            null     
        };

        travells[1] = "New York";

        Console.WriteLine(travells[0]);
        Console.WriteLine(travells[1]);
        Console.WriteLine(travells[2]);
        Console.WriteLine(travells[3]);

        travells[3] = "Paris";
        Console.WriteLine(travells[3]);
     
    }
} 