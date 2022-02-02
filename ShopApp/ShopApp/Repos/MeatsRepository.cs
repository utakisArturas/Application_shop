using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class MeatsRepository
    {
        public List<Meats> meatsList = ReadMeatsCsvService(); 

        public static List<Meats> ReadMeatsCsvService() 
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            var meatsList = csvContex.Read<Meats>("Meats.csv", csvFileDescription); 
            List<Meats> ListOfMeats = meatsList.ToList();


            return ListOfMeats;

        }
        public void PrintMeatsList()
        {
            foreach (var meat in meatsList)
            {
                Console.WriteLine($" || {meat.Barcode} || {meat.Price}Eur || {meat.Weight}gr. || {meat.Protein}grams of protein ||" );

            }
        }


    }
}
