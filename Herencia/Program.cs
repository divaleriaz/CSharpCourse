internal class Program
{
    private static void Main(string[] args)
    {
        Dev Dev1 = new Dev ("Bryan", 29, "Oshyn");
        Console.WriteLine(Dev1.GetInfo());
        Console.WriteLine(Dev1.GetData());

        Admin Admin1 = new Admin("Valeria", 22, "Labov");
        Console.WriteLine(Admin1.GetInfo());
        Console.WriteLine(Admin1.GetData());
    }

    class People 
    {
        private string _name;
        private int _age;

        public People  (string name, int age) 
        {
            _name = name;
            _age = age;
        }
        public string GetInfo()
        {
            return _name + " " + _age;
        }
    } 
    class Dev : People 
    {
        private string _work;
        public Dev (string name, int age, string work) : base (name, age) 
        {
            _work = work;
        }
        public string GetData()
        {
            return GetInfo() + " " + _work; 
        }


    }
    class Admin : People
    {
        private string _work;
        public Admin(string name, int age, string work) : base(name, age)
        {
            _work = work;
        }
        public string GetData()
        {
            return GetInfo() + " " + _work;
        }


    }

}