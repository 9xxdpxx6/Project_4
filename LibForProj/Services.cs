using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkings;

namespace LibForProj
{
    public static class Services
    {
        public static string AddToSum(bool isChecked, string label, double price)
        {
            if (isChecked)
                label = $"Текущая цена: {Quantities.Sum += price}";
            else
                label = $"Текущая цена: {Quantities.Sum -= price}";
            return label;
        }
    }
}
