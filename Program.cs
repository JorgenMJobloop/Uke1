namespace Uke1;

class Program
{
    static void Main(string[] args)
    {
        string helloWorld = "Jello World!";
        Console.WriteLine(helloWorld);

        // variabler

        double x = 7; // double: desimaltall
        int y = 5; // int: heltall
        Console.WriteLine(x / y);

        // metoder(funksjoner i andre språk)
        double Add(double a, double b)
        {
            return a * b;
        }

        Console.WriteLine(Add(5, 5)); // -> 25 

        // lager en ny instanse av klassen Person
        Person personEn = new Person();
        // gir objektet verdier
        personEn.Name = "Lars Gunnar";
        personEn.Age = 34;
        personEn.Gender = "Male";

        // eksempel på string concatinating


        // Console.WriteLine("Hei " + personEn.Name + "! Du er " + personEn.Age + " år gammel");

        // eksempel på string formatting
        Console.WriteLine($"Hei {personEn.Name}! Du er {personEn.Age} år gammel!");

        // ny initalisering av objekt ved å bruke Person klassen
        Person personTo = new Person();

        personTo.Name = "Jørgen"; // reassignet objektet
        personTo.Age = 30;
        personTo.Gender = "Male";

        Console.WriteLine($"Hei {personTo.Name}! Du er {personTo.Age} år gammel!");

        /**
        Datastrukturer
        **/
        string[] handleListe = { "Melk", "Brød", "Egg", "Brus", "Middag", "Snus" };

        Console.WriteLine("Her er handlelisten din:");

        /**
        for (int i = 0; i < handleListe.Length; i++)
        {
            Console.WriteLine(handleListe[i]); // henter ut strings fra index[] av i
        }
        **/
        foreach (string elementer in handleListe)
        {
            Console.WriteLine(elementer);
        }

        personEn.SayHello();

        // initialiserer et nytt utility objekt fra Utility klassen
        Utility utility = new Utility();
        string hello = "Hello";
        string world = "World";

        Console.WriteLine(utility.SimpleConcat(hello, world));

        bool canEnterTheClub = false;
        int age = 19;
        // ! blir en "shorthand" for å reassigne canEnterClub til true, dvs: canEnterClub = true; er det samme som : !canEnterTheClub dersom den originalt var tildelt som false.
        if (age >= 18 && !canEnterTheClub)
        {
            Console.WriteLine("You can enter the club!");
        }
        else
        {
            Console.WriteLine("You cannot enter the club");
        }

    }
}
