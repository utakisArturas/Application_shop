using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class Veggies :Product
    {
        [CsvColumn(Name = "fiber")]
        public double Fiber;
    }
}
