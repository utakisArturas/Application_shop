using LINQtoCSV;
using System;

namespace ShopApp
{
    [Serializable]
    internal class Sweets : Product
    {
        [CsvColumn(Name = "sugar")]
        public double Sugar { get; set; }
    }
}
