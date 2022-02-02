using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class DrinksRepository
    {
        public List<Drinks> drinkList = ReadDrinksCsvService();

        public static List<Drinks> ReadDrinksCsvService()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            var drinksList = csvContex.Read<Drinks>("Drinks.csv", csvFileDescription);
            List<Drinks> ListOfDrinks = drinksList.ToList();


            return ListOfDrinks;

        }
        public void PrintDrinksList()
        {
            foreach (var drink in drinkList)
            {
                Console.WriteLine($" || {drink.Barcode} || {drink.Price}Eur || {drink.Weight}gr. || {drink.Liter}l. ||");

            }
        }
    }
}
