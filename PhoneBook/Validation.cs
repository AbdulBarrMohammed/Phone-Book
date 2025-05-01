using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class Validation
    {
        internal static bool IsValidNumber(string number)
        {
            var r = new Regex(@"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$");

            return r.IsMatch(number);
        }

        internal static bool IsValidEmail(string email)
        {
            var r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return r.IsMatch(email);
        }
    }
}
