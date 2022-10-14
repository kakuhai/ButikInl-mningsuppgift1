using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShirtsAndMugs;
namespace ShirtsAndMugs
{
    class Shirts : IComparable<Shirts>
    {
        public static List<Shirts> ShirtsListCreate()
        {
            List<Shirts> ShirtsList = new List<Shirts>
            {
                new Shirts("Stockholm", "S, M, L, XL", 4.5, 149),
                new Shirts("Uppsala", "S, M, L, XL", 3.7, 149),
                new Shirts("Göteborg", "S, M, L", 4.1, 129),
                new Shirts("Malmö", "M, L, XL", 2.2, 149),
                new Shirts("Upplands Väsby", "S, L, XL", 5.0, 99),
                new Shirts("Västerås", "S, M, L, XL", 3.7, 129),
                new Shirts("Örebro", "S, L, XL", 3.8, 149),
                new Shirts("Linköping", "S, M", 2.4, 129),
                new Shirts("Helsingborg", "L, XL", 1.1, 99),
                new Shirts("Jönköping", "S, L, XL", 3.9, 129),
                new Shirts("Norrköping", "S, M, L, XL", 4.4, 99),
                new Shirts("Lund", "S, M, XL", 4.2,149),
                new Shirts("Umeå", "S, M", 2.9,149),
                new Shirts("Gävle", "S, XL", 3.3,99),
                new Shirts("Borås", "S, M, L, XL", 4.6,129),
                new Shirts("Södertälje", "S, M, XL", 3.8,99),
                new Shirts("Eskilstuna", "S, M, L, XL", 3.3,149),
                new Shirts("Halmstad", "S, L, XL", 4.4,99),
                new Shirts("Växjö", "M, L, XL", 4.8,129),
                new Shirts("Karlstad", "S, XL", 3.5,129),
                new Shirts("Sundsvall", "M, L, XL", 4.9,99),
                new Shirts("Östersund", "S, L", 2.8,149),
                new Shirts("Trollhättan", "S, M, L", 1.5,149),
                new Shirts("Nordöstra Göteborg", "S, M, L, XL", 3.0,149),
                new Shirts("Luleå", "M, L, XL", 4.0,99),
                new Shirts("Lidingö", "S, L, XL", 2.0,99),
                new Shirts("Borlänge", "M, L", 3.7,129),
                new Shirts("Tumba", "XL", 4.6,99),
                new Shirts("Kristianstad", "M, L, XL", 0.0,149),
                new Shirts("Kalmar", "S, M, L", 0.5,149),
            };
            return ShirtsList;
        }
        // Metod för att sortera tröjor från högt till lågt pris
        public static void ShirtsListSorted()
        {
            var shirts = ShirtsListCreate();
            shirts.Sort();
            foreach (Shirts Shirts in shirts)
            {
                Console.WriteLine(Shirts.Design + " " + Shirts.Size + " " + Shirts.UserRating + " " + Shirts.Price + ":-");
            }
        }
        // Metod för att sortera listan och sedan vända ordningen
        public static void ShirtsListSortedReverse()
        {
            var shirts = ShirtsListCreate();
            shirts.Sort();
            shirts.Reverse();
            foreach (Shirts Shirts in shirts)
            {
                Console.WriteLine(Shirts.Design + " " + Shirts.Size + " " + Shirts.UserRating + " " + Shirts.Price + ":-");
            }
        }

        // Berättar för icomparable vilket sätt den ska sortera tröjorna
        public int CompareTo(Shirts other)
        {
            if (Price > other.Price)
            {
                return -1;
            }
            else if (Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // Konstruktor för att kunna skapa tröjor
        public string Design { get; set; }
        public string Size { get; set; }
        public double UserRating { get; set; }
        public int Price { get; set; }
        public Shirts(string design, string size, double userRating, int price)
        {
            this.Design = design;
            this.Size = size;
            this.UserRating = userRating;
            this.Price = price;
        }
    }
    class Mugs : IComparable<Mugs>
    {
        public static List<Mugs> MugsListCreate()
        {
            List<Mugs> MugsList = new List<Mugs>
            {
                new Mugs("Stockholm", 3.7, 149),
                new Mugs("Uppsala", 4.5, 149),
                new Mugs("Göteborg", 4.2, 129),
                new Mugs("Malmö", 3.4, 149),
                new Mugs("Upplands Väsby", 2.8, 99),
                new Mugs("Västerås", 4.0, 129),
                new Mugs("Örebro", 4.5, 149),
                new Mugs("Linköping", 3.4, 129),
                new Mugs("Helsingborg", 3.2, 99),
                new Mugs("Jönköping", 4.4, 129),
                new Mugs("Norrköping", 0.0, 99),
                new Mugs("Lund", 4.7,149),
                new Mugs("Umeå", 3.0,149),
                new Mugs("Gävle", 2.6,99),
                new Mugs("Borås", 4.2,129),
                new Mugs("Södertälje", 3.1,99),
                new Mugs("Eskilstuna", 5.0,149),
                new Mugs("Halmstad", 4.9,99),
                new Mugs("Växjö", 2.2,129),
                new Mugs("Karlstad", 3.6,129),
                new Mugs("Sundsvall", 3.6,99),
                new Mugs("Östersund", 3.2,149),
                new Mugs("Trollhättan", 4.3,149),
                new Mugs("Nordöstra Göteborg", 3.9,149),
                new Mugs("Luleå", 2.0,99),
                new Mugs("Lidingö", 1.2,99),
                new Mugs("Borlänge", 3.3,129),
                new Mugs("Tumba", 4.4,99),
                new Mugs("Kristianstad", 5.0,149),
                new Mugs("Kalmar", 2.8,149),

            };
            return MugsList;
        }
        public static void MugsSorted()
        {
            var mugs = MugsListCreate();
            mugs.Sort();
            foreach (Mugs Mugs in mugs)
            {
                Console.WriteLine(Mugs.Design + " " + Mugs.UserRating + " " + Mugs.Price + ":-");
            }
        }
        public static void MugsSortedReverse()
        {
            var mugs = MugsListCreate();
            mugs.Sort();
            mugs.Reverse();
            foreach (Mugs Mugs in mugs)
            {
                Console.WriteLine(Mugs.Design + " " + Mugs.UserRating + " " + Mugs.Price + ":-");
            }
        }
        public string Design { get; set; }
        public double UserRating { get; set; }
        public int Price { get; set; }
        public int CompareTo(Mugs other)
        {
            if (UserRating > other.UserRating)
            {
                return -1;
            }
            else if (UserRating < other.UserRating)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public Mugs(string design, double userRating, int price)
        {
            Design = design;
            UserRating = userRating;
            Price = price;
        }
    }
}