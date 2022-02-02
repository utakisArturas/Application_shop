using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp
{
    internal class SweetsRepository
    {
        public List<Sweets> SweetsList = ReadSweetsCsvService(); 

        public static List<Sweets> ReadSweetsCsvService() 
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            var sweetsList = csvContex.Read<Sweets>("Sweets.csv", csvFileDescription); 
            List<Sweets> ListOfSweets = sweetsList.ToList();


            return ListOfSweets;

        }
        public void PrintSweetsList()
        {
            foreach (var sweet in SweetsList)
            {
                Console.WriteLine($" || {sweet.Barcode} || {sweet.Price}Eur || {sweet.Weight}gr. || {sweet.Sugar}grams of sugar ||");

            }
        }


    }
}
