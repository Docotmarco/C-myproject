using System;

namespace Animal_Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("            |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("            |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("            |||||||||||| ANIMALS  SWITCHCASE  STATEMENT |||||||||||||||");
            Console.WriteLine("            |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("            |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("________________________________________________________________________________________\n");

            string user, pass, name, animal;
            Console.Write("Enter name:\t\t");
            name = Console.ReadLine();
            Console.Write("Enter username:\t\t");
            user = Console.ReadLine();
            Console.Write("Enter password:\t\t");
            pass = Console.ReadLine();

            Console.WriteLine("");
            if (user == "maccoy" && pass == "123456" && name == "marco")
            {
                Console.WriteLine("\tHello! {0}", name);
                Console.WriteLine("REGULAR USER LOGIN SUCCESFULLY!");
                Console.WriteLine("");
            startA:
                Console.Write("Enter animal:\t\t");
                animal = Console.ReadLine();

                switch (animal)
                {
                    case "anaconda":
                    case "viper":
                    case "phython":
                    case "cobra":
                    case "mamba":
                    case "titanoboa":
                    case "colubrid":
                    case "taipan":
                    case "elapid":
                    case "lamprophis":
                        Console.WriteLine("{0} has 0 legs", animal);
                        Console.WriteLine("===================================");
                        break;
                    case "chicken":
                    case "pigeons":
                    case "owl":
                    case "parrot":
                    case "duck":
                    case "penguin":
                    case "finches":
                    case "sparrow":
                    case "kingfisher":
                    case "crane":
                        Console.WriteLine("{0} has 2 legs", animal);
                        Console.WriteLine("===================================");
                        break;
                    case "cat":
                    case "dog":
                    case "tiger":
                    case "lion":
                    case "rhino":
                    case "platypus":
                    case "elephant":
                    case "giraffe":
                    case "wolf":
                    case "bear":
                        Console.WriteLine("{0} has 4 legs", animal);
                        Console.WriteLine("===================================");
                        break;
                    default:
                        Console.WriteLine("Your animals: ( {0} ) are not found!", animal);
                        Console.WriteLine("===================================");
                        break;

                }
                goto startA;


            }
            else if (user == "admin" && pass == "123456" && name == "marco")
            {

                Console.WriteLine("\t\t WELCOME! {0}", name);
                Console.WriteLine("YOUR LOGIN TO ADMIN SUCCESFULLY!");
                Console.WriteLine("");
                Console.WriteLine("Press1\t\tOpt1 enter 5 animals");
                Console.WriteLine("");
                Console.WriteLine("Press2\t\tOpt2 enter 5 animals and the program will identify which animals have 0 legs");
                Console.WriteLine("");
                Console.WriteLine("Press3\t\tOpt3 enter 5 animals and the program will identify which animals have 2 legs");
                Console.WriteLine("");
                Console.WriteLine("Press4\t\tOpt4 enter 5 animals and the program will identify which animals have 4 legs");
                Console.WriteLine("");
            start:
                Console.Write("Enter option: ");
                string opt = Console.ReadLine();
                string animal1, animal2, animal3, animal4, animal5;
                if (opt == "1")
                {
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine("Enter 5 animals:");
                animal1:
                    animal1 = Console.ReadLine();
                    if (animal1 == "anaconda" || animal1 == "viper" || animal1 == "phython" ||
                        animal1 == "cobra" || animal1 == "mamba" || animal1 == "titanoboa" ||
                        animal1 == " colubrid" || animal1 == "taipan" || animal1 == "elapid" ||
                        animal1 == "lamprophis" || animal1 == "chicken" || animal1 == "pigeons" ||
                        animal1 == "owl" || animal1 == "crane" || animal1 == "parrot" || animal1 == "duck" ||
                        animal1 == "penguin" || animal1 == "finches" || animal1 == "sparrow" ||
                        animal1 == "kingfisher" || animal1 == "cat" || animal1 == "dog" || animal1 == "tiger" ||
                        animal1 == "lion" || animal1 == "rhino" || animal1 == "platypus" || animal1 == "elephant" ||
                        animal1 == "giraffe" || animal1 == "wolf" || animal1 == "bear")
                    {
                        goto animal2;
                    }
                    else
                    {
                        Console.WriteLine("Your animals: ( {0} ) are not found!", animal1);
                        goto animal1;
                    }
                animal2:
                    animal2 = Console.ReadLine();
                    if (animal2 == "anaconda" || animal2 == "viper" || animal2 == "phython" || animal2 == "cobra" || animal2 == "mamba" || animal2 == "titanoboa" || animal2 == " colubrid" || animal2 == "taipan" || animal2 == "elapid" || animal2 == "lamprophis" || animal2 == "chicken" || animal2 == "pigeons" || animal2 == "owl" || animal2 == "crane" || animal2 == "parrot" || animal2 == "duck" || animal2 == "penguin" || animal2 == "finches" || animal2 == "sparrow" || animal2 == "kingfisher" || animal2 == "cat" || animal2 == "dog" || animal2 == "tiger" || animal2 == "lion" || animal2 == "rhino" || animal2 == "platypus" || animal2 == "elephant" || animal2 == "giraffe" || animal2 == "wolf" || animal2 == "bear")
                    {
                        goto animal3;
                    }
                    else
                    {
                        Console.WriteLine("Your animals: ( {0} ) are not found!", animal2);
                        goto animal2;
                    }
                animal3:
                    animal3 = Console.ReadLine();
                    if (animal3 == "anaconda" || animal3 == "viper" || animal3 == "phython" || animal3 == "cobra" || animal3 == "mamba" || animal3 == "titanoboa" || animal3 == " colubrid" || animal3 == "taipan" || animal3 == "elapid" || animal3 == "lamprophis" || animal3 == "chicken" || animal3 == "pigeons" || animal3 == "owl" || animal3 == "crane" || animal3 == "parrot" || animal3 == "duck" || animal3 == "penguin" || animal3 == "finches" || animal3 == "sparrow" || animal3 == "kingfisher" || animal3 == "cat" || animal3 == "dog" || animal3 == "tiger" || animal3 == "lion" || animal3 == "rhino" || animal3 == "platypus" || animal3 == "elephant" || animal3 == "giraffe" || animal3 == "wolf" || animal3 == "bear")
                    {
                        goto animal4;
                    }
                    else
                    {
                        Console.WriteLine("Your animals: ( {0} ) are not found!", animal3);
                        goto animal3;
                    }
                animal4:
                    animal4 = Console.ReadLine();
                    if (animal4 == "anaconda" || animal4 == "viper" || animal4 == "phython" || animal4 == "cobra" || animal4 == "mamba" || animal4 == "titanoboa" || animal4 == " colubrid" || animal4 == "taipan" || animal4 == "elapid" || animal4 == "lamprophis" || animal4 == "chicken" || animal4 == "pigeons" || animal4 == "owl" || animal4 == "crane" || animal4 == "parrot" || animal4 == "duck" || animal4 == "penguin" || animal4 == "finches" || animal4 == "sparrow" || animal4 == "kingfisher" || animal4 == "cat" || animal4 == "dog" || animal4 == "tiger" || animal4 == "lion" || animal4 == "rhino" || animal4 == "platypus" || animal4 == "elephant" || animal4 == "giraffe" || animal4 == "wolf" || animal4 == "bear")
                    {
                        goto animal5;
                    }
                    else
                    {
                        Console.WriteLine("Your animals: ( {0} ) are not found!", animal4);
                        goto animal4;
                    }
                animal5:
                    animal5 = Console.ReadLine();
                    if (animal5 == "anaconda" || animal5 == "viper" || animal5 == "phython" || animal5 == "cobra" || animal5 == "mamba" || animal5 == "titanoboa" || animal5 == " colubrid" || animal5 == "taipan" || animal5 == "elapid" || animal5 == "lamprophis" || animal5 == "chicken" || animal5 == "pigeons" || animal5 == "owl" || animal5 == "crane" || animal5 == "parrot" || animal5 == "duck" || animal5 == "penguin" || animal5 == "finches" || animal5 == "sparrow" || animal5 == "kingfisher" || animal5 == "cat" || animal5 == "dog" || animal5 == "tiger" || animal5 == "lion" || animal5 == "rhino" || animal5 == "platypus" || animal5 == "elephant" || animal5 == "giraffe" || animal5 == "wolf" || animal5 == "bear")
                    {

                    }
                    else
                    {
                        Console.WriteLine(" Your animals: ( {0} ) are not found!", animal5);
                        goto animal5;
                    }
                    Console.WriteLine("======================================================================================");

                    switch (animal1)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}\t\t has\t\t 0 legs", animal1);
                            Console.WriteLine("");
                            break;
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}\t\t has\t\t 2 legs", animal1);
                            Console.WriteLine("");
                            break;
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}\t\t has\t\t 4 legs", animal1);
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Your Animals are not found!");
                            Console.WriteLine("");
                            break;
                    }
                    switch (animal2)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}\t\t has\t\t 0 legs", animal2);
                            Console.WriteLine("");
                            break;
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}\t\t has\t\t 2 legs", animal2);
                            Console.WriteLine("");
                            break;
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}\t\t has\t\t 4 legs", animal2);
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Your Animals are not found!");
                            Console.WriteLine("");
                            break;
                    }
                    switch (animal3)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}\t\t has\t\t 0 legs", animal3);
                            Console.WriteLine("");
                            break;
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}\t\t has\t\t 2 legs", animal3);
                            Console.WriteLine("");
                            break;
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}\t\t has\t\t 4 legs", animal3);
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine(" Your Animals are not found!");
                            Console.WriteLine("");
                            break;
                    }
                    switch (animal4)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}\t\t has\t\t 0 legs", animal4);
                            Console.WriteLine("");
                            break;
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}\t\t has\t\t 2 legs", animal4);
                            Console.WriteLine("");
                            break;
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}\t\t has\t\t 4 legs", animal4);
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Your animals:( {0} ) are not found!", animal4);
                            Console.WriteLine("");
                            break;
                    }
                    switch (animal5)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}\t\t has\t\t 0 legs", animal5);
                            Console.WriteLine("");
                            break;
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}\t\t has\t\t 2 legs", animal5);
                            Console.WriteLine("");
                            break;
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}\t\t has\t\t 4 legs", animal5);
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Your animals:( {0} ) are not found!", animal5);
                            Console.WriteLine("");
                            break;
                    }


                }
                else if (opt == "2")
                {
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine("Enter 5 animals:");
                animal1:
                    animal1 = Console.ReadLine();
                    if (animal1 == "anaconda" || animal1 == "viper" || animal1 == "phython" || animal1 == "cobra" || animal1 == "mamba" || animal1 == "titanoboa" || animal1 == " colubrid" || animal1 == "taipan" || animal1 == "elapid" || animal1 == "lamprophis" || animal1 == "chicken" || animal1 == "pigeons" || animal1 == "owl" || animal1 == "crane" || animal1 == "parrot" || animal1 == "duck" || animal1 == "penguin" || animal1 == "finches" || animal1 == "sparrow" || animal1 == "kingfisher" || animal1 == "cat" || animal1 == "dog" || animal1 == "tiger" || animal1 == "lion" || animal1 == "rhino" || animal1 == "platypus" || animal1 == "elephant" || animal1 == "giraffe" || animal1 == "wolf" || animal1 == "bear")
                    {
                        goto animal2;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal1);
                        goto animal1;
                    }
                animal2:
                    animal2 = Console.ReadLine();
                    if (animal2 == "anaconda" || animal2 == "viper" || animal2 == "phython" || animal2 == "cobra" || animal2 == "mamba" || animal2 == "titanoboa" || animal2 == " colubrid" || animal2 == "taipan" || animal2 == "elapid" || animal2 == "lamprophis" || animal2 == "chicken" || animal2 == "pigeons" || animal2 == "owl" || animal2 == "crane" || animal2 == "parrot" || animal2 == "duck" || animal2 == "penguin" || animal2 == "finches" || animal2 == "sparrow" || animal2 == "kingfisher" || animal2 == "cat" || animal2 == "dog" || animal2 == "tiger" || animal2 == "lion" || animal2 == "rhino" || animal2 == "platypus" || animal2 == "elephant" || animal2 == "giraffe" || animal2 == "wolf" || animal2 == "bear")
                    {
                        goto animal3;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal2);
                        goto animal2;
                    }
                animal3:
                    animal3 = Console.ReadLine();
                    if (animal3 == "anaconda" || animal3 == "viper" || animal3 == "phython" || animal3 == "cobra" || animal3 == "mamba" || animal3 == "titanoboa" || animal3 == " colubrid" || animal3 == "taipan" || animal3 == "elapid" || animal3 == "lamprophis" || animal3 == "chicken" || animal3 == "pigeons" || animal3 == "owl" || animal3 == "crane" || animal3 == "parrot" || animal3 == "duck" || animal3 == "penguin" || animal3 == "finches" || animal3 == "sparrow" || animal3 == "kingfisher" || animal3 == "cat" || animal3 == "dog" || animal3 == "tiger" || animal3 == "lion" || animal3 == "rhino" || animal3 == "platypus" || animal3 == "elephant" || animal3 == "giraffe" || animal3 == "wolf" || animal3 == "bear")
                    {
                        goto animal4;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal3);
                        goto animal3;
                    }

                animal4:
                    animal4 = Console.ReadLine();
                    if (animal4 == "anaconda" || animal4 == "viper" || animal4 == "phython" || animal4 == "cobra" || animal4 == "mamba" || animal4 == "titanoboa" || animal4 == " colubrid" || animal4 == "taipan" || animal4 == "elapid" || animal4 == "lamprophis" || animal4 == "chicken" || animal4 == "pigeons" || animal4 == "owl" || animal4 == "crane" || animal4 == "parrot" || animal4 == "duck" || animal4 == "penguin" || animal4 == "finches" || animal4 == "sparrow" || animal4 == "kingfisher" || animal4 == "cat" || animal4 == "dog" || animal4 == "tiger" || animal4 == "lion" || animal4 == "rhino" || animal4 == "platypus" || animal4 == "elephant" || animal4 == "giraffe" || animal4 == "wolf" || animal4 == "bear")
                    {
                        goto animal5;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal4);
                        goto animal4;
                    }
                animal5:

                    animal5 = Console.ReadLine();
                    if (animal5 == "anaconda" || animal5 == "viper" || animal5 == "phython" || animal5 == "cobra" || animal5 == "mamba" || animal5 == "titanoboa" || animal5 == " colubrid" || animal5 == "taipan" || animal5 == "elapid" || animal5 == "lamprophis" || animal5 == "chicken" || animal5 == "pigeons" || animal5 == "owl" || animal5 == "crane" || animal5 == "parrot" || animal5 == "duck" || animal5 == "penguin" || animal5 == "finches" || animal5 == "sparrow" || animal5 == "kingfisher" || animal5 == "cat" || animal5 == "dog" || animal5 == "tiger" || animal5 == "lion" || animal5 == "rhino" || animal5 == "platypus" || animal5 == "elephant" || animal5 == "giraffe" || animal5 == "wolf" || animal5 == "bear")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal5);
                        goto animal5;
                    }
                    Console.WriteLine("======================================================================================");
                    switch (animal1)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}", animal1);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal2)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}", animal2);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal3)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}", animal3);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal4)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}", animal4);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal5)
                    {
                        case "anaconda":
                        case "viper":
                        case "phython":
                        case "cobra":
                        case "mamba":
                        case "titanoboa":
                        case "colubrid":
                        case "taipan":
                        case "elapid":
                        case "lamprophis":
                            Console.WriteLine("{0}", animal5);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }

                }
                else if (opt == "3")
                {
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine("Enter 5 animals:");
                animal1:
                    animal1 = Console.ReadLine();
                    if (animal1 == "anaconda" || animal1 == "viper" || animal1 == "phython" || animal1 == "cobra" || animal1 == "mamba" || animal1 == "titanoboa" || animal1 == " colubrid" || animal1 == "taipan" || animal1 == "elapid" || animal1 == "lamprophis" || animal1 == "chicken" || animal1 == "pigeons" || animal1 == "owl" || animal1 == "crane" || animal1 == "parrot" || animal1 == "duck" || animal1 == "penguin" || animal1 == "finches" || animal1 == "sparrow" || animal1 == "kingfisher" || animal1 == "cat" || animal1 == "dog" || animal1 == "tiger" || animal1 == "lion" || animal1 == "rhino" || animal1 == "platypus" || animal1 == "elephant" || animal1 == "giraffe" || animal1 == "wolf" || animal1 == "bear")
                    {
                        goto animal2;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal1);
                        goto animal1;
                    }
                animal2:
                    animal2 = Console.ReadLine();
                    if (animal2 == "anaconda" || animal2 == "viper" || animal2 == "phython" || animal2 == "cobra" || animal2 == "mamba" || animal2 == "titanoboa" || animal2 == " colubrid" || animal2 == "taipan" || animal2 == "elapid" || animal2 == "lamprophis" || animal2 == "chicken" || animal2 == "pigeons" || animal2 == "owl" || animal2 == "crane" || animal2 == "parrot" || animal2 == "duck" || animal2 == "penguin" || animal2 == "finches" || animal2 == "sparrow" || animal2 == "kingfisher" || animal2 == "cat" || animal2 == "dog" || animal2 == "tiger" || animal2 == "lion" || animal2 == "rhino" || animal2 == "platypus" || animal2 == "elephant" || animal2 == "giraffe" || animal2 == "wolf" || animal2 == "bear")
                    {
                        goto animal3;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal2);
                        goto animal2;
                    }
                animal3:
                    animal3 = Console.ReadLine();
                    if (animal3 == "anaconda" || animal3 == "viper" || animal3 == "phython" || animal3 == "cobra" || animal3 == "mamba" || animal3 == "titanoboa" || animal3 == " colubrid" || animal3 == "taipan" || animal3 == "elapid" || animal3 == "lamprophis" || animal3 == "chicken" || animal3 == "pigeons" || animal3 == "owl" || animal3 == "crane" || animal3 == "parrot" || animal3 == "duck" || animal3 == "penguin" || animal3 == "finches" || animal3 == "sparrow" || animal3 == "kingfisher" || animal3 == "cat" || animal3 == "dog" || animal3 == "tiger" || animal3 == "lion" || animal3 == "rhino" || animal3 == "platypus" || animal3 == "elephant" || animal3 == "giraffe" || animal3 == "wolf" || animal3 == "bear")
                    {
                        goto animal4;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal3);
                        goto animal3;
                    }
                animal4:
                    animal4 = Console.ReadLine();
                    if (animal4 == "anaconda" || animal4 == "viper" || animal4 == "phython" || animal4 == "cobra" || animal4 == "mamba" || animal4 == "titanoboa" || animal4 == " colubrid" || animal4 == "taipan" || animal4 == "elapid" || animal4 == "lamprophis" || animal4 == "chicken" || animal4 == "pigeons" || animal4 == "owl" || animal4 == "crane" || animal4 == "parrot" || animal4 == "duck" || animal4 == "penguin" || animal4 == "finches" || animal4 == "sparrow" || animal4 == "kingfisher" || animal4 == "cat" || animal4 == "dog" || animal4 == "tiger" || animal4 == "lion" || animal4 == "rhino" || animal4 == "platypus" || animal4 == "elephant" || animal4 == "giraffe" || animal4 == "wolf" || animal4 == "bear")
                    {
                        goto animal5;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal4);
                        goto animal4;
                    }
                animal5:
                    animal5 = Console.ReadLine();
                    if (animal5 == "anaconda" || animal5 == "viper" || animal5 == "phython" || animal5 == "cobra" || animal5 == "mamba" || animal5 == "titanoboa" || animal5 == " colubrid" || animal5 == "taipan" || animal5 == "elapid" || animal5 == "lamprophis" || animal5 == "chicken" || animal5 == "pigeons" || animal5 == "owl" || animal5 == "crane" || animal5 == "parrot" || animal5 == "duck" || animal5 == "penguin" || animal5 == "finches" || animal5 == "sparrow" || animal5 == "kingfisher" || animal5 == "cat" || animal5 == "dog" || animal5 == "tiger" || animal5 == "lion" || animal5 == "rhino" || animal5 == "platypus" || animal5 == "elephant" || animal5 == "giraffe" || animal5 == "wolf" || animal5 == "bear")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal5);
                        goto animal5;
                    }
                    Console.WriteLine("======================================================================================");
                    switch (animal1)
                    {
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}", animal1);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal2)
                    {
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}", animal2);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal3)
                    {
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}", animal3);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal4)
                    {
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}", animal4);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal5)
                    {
                        case "chicken":
                        case "pigeons":
                        case "owl":
                        case "parrot":
                        case "duck":
                        case "penguin":
                        case "finches":
                        case "sparrow":
                        case "kingfisher":
                        case "crane":
                            Console.WriteLine("{0}", animal5);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                }
                else if (opt == "4")
                {
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine("Enter 5 animals:");
                animal1:
                    animal1 = Console.ReadLine();
                    if (animal1 == "anaconda" || animal1 == "viper" || animal1 == "phython" || animal1 == "cobra" || animal1 == "mamba" || animal1 == "titanoboa" || animal1 == " colubrid" || animal1 == "taipan" || animal1 == "elapid" || animal1 == "lamprophis" || animal1 == "chicken" || animal1 == "pigeons" || animal1 == "owl" || animal1 == "crane" || animal1 == "parrot" || animal1 == "duck" || animal1 == "penguin" || animal1 == "finches" || animal1 == "sparrow" || animal1 == "kingfisher" || animal1 == "cat" || animal1 == "dog" || animal1 == "tiger" || animal1 == "lion" || animal1 == "rhino" || animal1 == "platypus" || animal1 == "elephant" || animal1 == "giraffe" || animal1 == "wolf" || animal1 == "bear")
                    {
                        goto animal2;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal1);
                        goto animal1;
                    }
                animal2:
                    animal2 = Console.ReadLine();
                    if (animal2 == "anaconda" || animal2 == "viper" || animal2 == "phython" || animal2 == "cobra" || animal2 == "mamba" || animal2 == "titanoboa" || animal2 == " colubrid" || animal2 == "taipan" || animal2 == "elapid" || animal2 == "lamprophis" || animal2 == "chicken" || animal2 == "pigeons" || animal2 == "owl" || animal2 == "crane" || animal2 == "parrot" || animal2 == "duck" || animal2 == "penguin" || animal2 == "finches" || animal2 == "sparrow" || animal2 == "kingfisher" || animal2 == "cat" || animal2 == "dog" || animal2 == "tiger" || animal2 == "lion" || animal2 == "rhino" || animal2 == "platypus" || animal2 == "elephant" || animal2 == "giraffe" || animal2 == "wolf" || animal2 == "bear")
                    {
                        goto animal3;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal2);
                        goto animal2;
                    }
                animal3:
                    animal3 = Console.ReadLine();
                    if (animal3 == "anaconda" || animal3 == "viper" || animal3 == "phython" || animal3 == "cobra" || animal3 == "mamba" || animal3 == "titanoboa" || animal3 == " colubrid" || animal3 == "taipan" || animal3 == "elapid" || animal3 == "lamprophis" || animal3 == "chicken" || animal3 == "pigeons" || animal3 == "owl" || animal3 == "crane" || animal3 == "parrot" || animal3 == "duck" || animal3 == "penguin" || animal3 == "finches" || animal3 == "sparrow" || animal3 == "kingfisher" || animal3 == "cat" || animal3 == "dog" || animal3 == "tiger" || animal3 == "lion" || animal3 == "rhino" || animal3 == "platypus" || animal3 == "elephant" || animal3 == "giraffe" || animal3 == "wolf" || animal3 == "bear")
                    {
                        goto animal4;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal3);
                        goto animal3;
                    }
                animal4:
                    animal4 = Console.ReadLine();
                    if (animal4 == "anaconda" || animal4 == "viper" || animal4 == "phython" || animal4 == "cobra" || animal4 == "mamba" || animal4 == "titanoboa" || animal4 == " colubrid" || animal4 == "taipan" || animal4 == "elapid" || animal4 == "lamprophis" || animal4 == "chicken" || animal4 == "pigeons" || animal4 == "owl" || animal4 == "crane" || animal4 == "parrot" || animal4 == "duck" || animal4 == "penguin" || animal4 == "finches" || animal4 == "sparrow" || animal4 == "kingfisher" || animal4 == "cat" || animal4 == "dog" || animal4 == "tiger" || animal4 == "lion" || animal4 == "rhino" || animal4 == "platypus" || animal4 == "elephant" || animal4 == "giraffe" || animal4 == "wolf" || animal4 == "bear")
                    {
                        goto animal5;
                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal4);
                        goto animal4;
                    }
                animal5:
                    animal5 = Console.ReadLine();
                    if (animal5 == "anaconda" || animal5 == "viper" || animal5 == "phython" || animal5 == "cobra" || animal5 == "mamba" || animal5 == "titanoboa" || animal5 == " colubrid" || animal5 == "taipan" || animal5 == "elapid" || animal5 == "lamprophis" || animal5 == "chicken" || animal5 == "pigeons" || animal5 == "owl" || animal5 == "crane" || animal5 == "parrot" || animal5 == "duck" || animal5 == "penguin" || animal5 == "finches" || animal5 == "sparrow" || animal5 == "kingfisher" || animal5 == "cat" || animal5 == "dog" || animal5 == "tiger" || animal5 == "lion" || animal5 == "rhino" || animal5 == "platypus" || animal5 == "elephant" || animal5 == "giraffe" || animal5 == "wolf" || animal5 == "bear")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Your animals:( {0} ) are not found!", animal5);
                        goto animal5;
                    }
                    Console.WriteLine("======================================================================================");
                    switch (animal1)
                    {
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}", animal1);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal2)
                    {
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}", animal2);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal3)
                    {
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}", animal3);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal4)
                    {
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}", animal4);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    switch (animal5)
                    {
                        case "cat":
                        case "dog":
                        case "tiger":
                        case "lion":
                        case "rhino":
                        case "platypus":
                        case "elephant":
                        case "giraffe":
                        case "wolf":
                        case "bear":
                            Console.WriteLine("{0}", animal5);
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid option!");
                    Console.WriteLine("");
                }
                goto start;
            }
            else
            {
                Console.WriteLine("Invalid!... Maybe user, pass, and name!");
            }

            Console.ReadLine();
        }
    }
}
