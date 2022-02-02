using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class Drinks :Product
    {
        [CsvColumn(Name = "liters")]
        public double Liter;
    }
}
