namespace ShirtsAndMugs
{
    class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
                // Huvudmeny med switch för användarval.
                ClearAndShowHeading("Welcome to Shirts and Mugs!\n\n");
                Console.WriteLine("1) View shirts.\n" +
                    "2) View mugs.\n" +
                    "3) Exit.\n");

                Console.Write("\nSelect an option: ");

                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        DisplayShirtsMenu();
                        break;
                    case "2":
                        DisplayMugsMenu();
                        break;
                    case "3":
                        ClearAndShowHeading("Thank you for visiting our store!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        InvalidOption();
                        GoToMainMenu();
                        break;
                };
            }
        }
        // Estetisk metod för att först rensa konsolen, sedan visa rubrik samt en separator av samma längd som strängen (heading)
        private static void ClearAndShowHeading(string heading)
        {
            Console.Clear();
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading?.Length ?? 0));
        }
        // Metod som visar meny för tröjor samt en switch för användarval. Istället för att nästla min switch för undermenyer så kallar jag på separata metoder som inkluderar en ny switch för sina respektive menyer.
        private static void DisplayShirtsMenu()
        {
            ClearAndShowHeading("Shirts\n\n");
            Console.WriteLine("1) View shirts sorted by price (descending).\n" +
            "2) View shirts sorted by price (ascending).\n" +
            "3) Return to main menu.\n");
            Console.Write("\nSelect an option: ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    DisplayShirtsSorted();
                    break;
                case "2":
                    DisplayShirtsSortedReverse();
                    break;
                case "3":
                    GoToMainMenu();
                    break;
                default:
                    InvalidOption();
                    DisplayShirtsMenu();
                    break;
            }
        }
        // Metod som visar tröjor sorterade efter fallande pris.
        private static void DisplayShirtsSorted()
        {
            ClearAndShowHeading("Shirts sorted by price (descending).");
            Shirts.ShirtsListSorted();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayShirtsMenu();
        }
        // Samma som ovan i stigande ordning.
        private static void DisplayShirtsSortedReverse()
        {
            ClearAndShowHeading("Shirts sorted by price (ascending).");
            Shirts.ShirtsListSortedReverse();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayShirtsMenu();
        }
        // Lika som DisplayShirtMenu i stort sett
        private static void DisplayMugsMenu()
        {
            ClearAndShowHeading("Mugs\n\n");
            Console.WriteLine("1) View mugs sorted by rating (descending).\n" +
            "2) View mugs sorted by rating (ascending).\n" +
            "3) Return to main menu.\n");
            Console.Write("\nSelect an option: ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    DisplayMugsSorted();
                    break;
                case "2":
                    DisplayMugsSortedReverse();
                    break;
                case "3":
                    GoToMainMenu();
                    break;
                default: 
                    InvalidOption();
                    DisplayMugsMenu();
                    break;
            }
        }
        // Metod som visar användaren muggar sorterade efter betyg i fallande ordning.
        private static void DisplayMugsSorted()
        {
            ClearAndShowHeading("Mugs sorted by rating (descending).");
            Mugs.MugsSorted();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayMugsMenu();
        }
        // Samma som ovan i stigande ordning.
        private static void DisplayMugsSortedReverse()
        {
            ClearAndShowHeading("Mugs sorted by rating (ascending).");
            Mugs.MugsSortedReverse();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayMugsMenu();
        }
        // Möjligtvis onödig metod för att återvända användaren till huvudmenyn.
        private static void GoToMainMenu()
        {
            MainMenu();
            Console.ReadKey();
        }
        // Metod för felmeddelande ifall användaren matar in något annat än accepterade val.
        private static void InvalidOption()
        {
            ClearAndShowHeading("Oops!\n\n");
            Console.WriteLine("Invalid input.\n\n");
            Console.Write("Press any key to return to previous menu...");
            Console.ReadKey();
        }
    }
}