using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class OrderFieldItem
    {
        public string FieldName { get; set; }
        public string Pseudonym { get; set; }

        public OrderFieldItem(string fieldName, string pseudonym)
        {
            FieldName = fieldName;
            Pseudonym = pseudonym;
        }
    }
}
