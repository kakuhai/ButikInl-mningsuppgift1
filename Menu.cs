namespace ShirtsAndMugs
{
    class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
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
        private static void ClearAndShowHeading(string heading)
        {
            Console.Clear();
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading?.Length ?? 0));
        }
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
        private static void DisplayShirtsSorted()
        {
            ClearAndShowHeading("Shirts sorted by price (descending).");
            Shirts.ShirtsListSorted();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayShirtsMenu();
        }
        private static void DisplayShirtsSortedReverse()
        {
            ClearAndShowHeading("Shirts sorted by price (ascending).");
            Shirts.ShirtsListSortedReverse();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayShirtsMenu();
        }
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
        private static void DisplayMugsSorted()
        {
            ClearAndShowHeading("Mugs sorted by rating (descending).");
            Merch.MugsSorted();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayMugsMenu();
        }
        private static void DisplayMugsSortedReverse()
        {
            ClearAndShowHeading("Mugs sorted by rating (ascending).");
            Merch.MugsSortedReverse();
            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DisplayMugsMenu();
        }
        private static void GoToMainMenu()
        {
            MainMenu();
            Console.ReadKey();
        }
        private static void InvalidOption()
        {
            ClearAndShowHeading("Oops!\n\n");
            Console.WriteLine("Invalid input.");
            Console.Write("Press any key to return to previous menu...");
            Console.ReadKey();
        }
    }
}