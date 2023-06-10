namespace Tilmeldingssystemet
{
    internal class Program
    {
        static void Main(string[] args)
            //Creating instances of the class 'Person'
        {
            Person Person1 = new Person(001, "Gülsüm", "Maglehøjen", "Roskilde", DateTime.Parse("19-02-1999"), true);
            Person Person2 = new Person(002, "Nuriye", "Maglehøjen", "Roskilde", DateTime.Parse("19-02-1999"), false);

            //Printing to console

            Console.WriteLine(Person1);
            Console.WriteLine(Person2);



            //Creating instances of the class ''Tilmeldingskatalog''

            //Tilmeldingskatalog Nummer1 = new Tilmeldingskatalog("Julelejr 2023", true, DateTime("01.01.23"), DateTime.Parse("01.02.23"));
            Tilmeldingskatalog Nummer1 = new Tilmeldingskatalog("Julelejr 2023", true, DateTime.Parse("01-01-23"), DateTime.Parse("01-02-23"));

            Console.WriteLine(Nummer1);
        }
    }
    
}