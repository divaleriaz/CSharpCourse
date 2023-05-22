internal class Program
{
    private static void Main(string[] args)
    {
        string[] travells = new string[5]
            {
            "Mexico",
            "Argentina",
            "Aruba",
            "Paris",
            null
            };

        bool run = true;
        for (int a = 0; a<travells.Length ; a++)
        {
            Console.WriteLine(travells[a]);
        }
    }
}