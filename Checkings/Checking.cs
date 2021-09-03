using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Checkings
{
    public class Checking
    {
        public static bool ValidEmailFound(string email)
        {
            string valid = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, valid);
            return isMatch.Success;
        }
        public static bool ValidSymFound(string str)
        {
            string valid = "[А-Яа-я- \"]";
            Match isMatch = Regex.Match(str, valid);
            return isMatch.Success;
        }
        public static bool ValidCharFound(string str)
        {
            double a;
            return double.TryParse(str, out a);
        }
    }
}
