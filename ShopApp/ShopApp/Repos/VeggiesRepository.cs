using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class VeggiesRepository
    {
        public List<Veggies> veggiesList = ReadVeggiesCsvService();

        public static List<Veggies> ReadVeggiesCsvService()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            var veggiesList = csvContex.Read<Veggies>("Veggies.csv", csvFileDescription);
            List<Veggies> ListOfVeggies = veggiesList.ToList();


            return ListOfVeggies;

        }
        public void PrintVeggiesList()
        {
            foreach (var veggie in veggiesList)
            {
                Console.WriteLine($" || {veggie.Barcode} || {veggie.Price}Eur || {veggie.Weight}gr. || {veggie.Fiber}grams of fiber ||");

            }
        }
    }
}
