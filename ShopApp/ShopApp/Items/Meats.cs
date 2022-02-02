using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class Meats :Product
    {
        [CsvColumn(Name = "protein")]
        public double Protein {get;set;}
    }
}
