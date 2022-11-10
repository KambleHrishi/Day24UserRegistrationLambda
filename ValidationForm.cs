using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24UserRegistrationLambda
{
    public class ValidationForm
    {
        public const string FIRST_NAME_REGEX = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
        public void FirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
    }
}
