using System;

class Program
{
    static void Main(string[] args)
    {
        string? userChoice = "";  // Make userChoice nullable
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Software Development Process");
            Console.WriteLine("b. Programming Paradigms");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine()?.ToLower(); // Null-safe assignment

            if (userChoice == null || userChoice == "c") // Check for null and close option
            {
                exit = true;
                goto End;
            }
            else if (userChoice == "a")
            {
                goto SoftwareDevelopmentProcess;
            }
            else if (userChoice == "b")
            {
                goto ProgrammingParadigms;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }
        }

    SoftwareDevelopmentProcess:
        Console.WriteLine("Software Development Process");
        Console.WriteLine("a. Traditional");
        Console.WriteLine("b. Agile");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine()?.ToLower();

        if (userChoice == null)
        {
            Console.WriteLine("Input cannot be null.");
            goto SoftwareDevelopmentProcess;
        }
        else if (userChoice == "a")
        {
            goto Traditional;
        }
        else if (userChoice == "b")
        {
            goto Agile;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto SoftwareDevelopmentProcess;
        }

    Traditional:
        while (true) // Replaced goto with loop
        {
            Console.WriteLine("Traditional");
            Console.WriteLine("a. Waterfall Model");
            Console.WriteLine("b. V-Model");
            Console.WriteLine("c. Back");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine()?.ToLower();

            if (userChoice == null)
            {
                Console.WriteLine("Input cannot be null.");
                continue;
            }
            else if (userChoice == "a")
            {
                Console.WriteLine("Waterfall Model");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("V-Model");
            }
            else if (userChoice == "c")
            {
                goto SoftwareDevelopmentProcess;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    Agile:
        while (true) // Replaced goto with loop
        {
            Console.WriteLine("Agile");
            Console.WriteLine("a. Scrum");
            Console.WriteLine("b. Kanban");
            Console.WriteLine("c. Back");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine()?.ToLower();

            if (userChoice == null)
            {
                Console.WriteLine("Input cannot be null.");
                continue;
            }
            else if (userChoice == "a")
            {
                Console.WriteLine("Scrum");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("Kanban");
            }
            else if (userChoice == "c")
            {
                goto SoftwareDevelopmentProcess;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    ProgrammingParadigms:
        Console.WriteLine("Programming Paradigms");
        Console.WriteLine("a. Imperative");
        Console.WriteLine("b. Declarative");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine()?.ToLower();

        if (userChoice == null)
        {
            Console.WriteLine("Input cannot be null.");
            goto ProgrammingParadigms;
        }
        else if (userChoice == "a")
        {
            goto Imperative;
        }
        else if (userChoice == "b")
        {
            goto Declarative;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ProgrammingParadigms;
        }

    Imperative:
        while (true) // Replaced goto with loop
        {
            Console.WriteLine("Imperative");
            Console.WriteLine("a. Procedural Programming");
            Console.WriteLine("b. Object-Oriented Programming");
            Console.WriteLine("c. Back");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine()?.ToLower();

            if (userChoice == null)
            {
                Console.WriteLine("Input cannot be null.");
                continue;
            }
            else if (userChoice == "a")
            {
                Console.WriteLine("Procedural Programming");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("Object-Oriented Programming");
            }
            else if (userChoice == "c")
            {
                goto ProgrammingParadigms;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    Declarative:
        while (true) // Replaced goto with loop
        {
            Console.WriteLine("Declarative");
            Console.WriteLine("a. Functional Programming");
            Console.WriteLine("b. Logic Programming");
            Console.WriteLine("c. Back");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine()?.ToLower();

            if (userChoice == null)
            {
                Console.WriteLine("Input cannot be null.");
                continue;
            }
            else if (userChoice == "a")
            {
                Console.WriteLine("Functional Programming");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("Logic Programming");
            }
            else if (userChoice == "c")
            {
                goto ProgrammingParadigms;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    End:
        Console.WriteLine("Closing the program...");
    }
}
