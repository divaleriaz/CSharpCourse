internal class Program
{
    private static void Main(string[] args)
    {
        bool areYouOfAge = true;
        bool YouWantToGoANightclub = true;

        if (areYouOfAge && YouWantToGoANightclub && Answer("tienes una invitación", 16))
        {
            Console.WriteLine("Puedes entrar");
        }
        else
        {
            Console.WriteLine("No puedes entrar");
        }
    }
    static bool Answer(string invitation, int age = 18)
    {
        if (age > 18 && invitation == "tienes una invitación")
        {
            return true;
        }
        else if (invitation == "no tienes una invitación")
        {
            return false;
        }
        else
        {
            return false;
        }
    }

}

   