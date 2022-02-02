using LINQtoCSV;
using System;

namespace ShopApp
{
    [Serializable]
    internal class Product
    {
        [CsvColumn(Name = "price")]
        public decimal Price { get; set; }
        [CsvColumn(Name = "barcode")]
        public string Barcode { get; set; }
        [CsvColumn(Name = "weight")]
        public double Weight { get; set; }
    }
}
