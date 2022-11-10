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

        public const string LAST_NAME_REGEX = @"^[A-Z]{1}[a-zA-Z]{2,9}$";

        public void LastName(string lastname)
        {
            Regex regex = new Regex(LAST_NAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
        public const string EMAILID_REGEX = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]";

        public void EmailID(string emailid)
        {
            Regex regex = new Regex(EMAILID_REGEX);
            bool result = regex.IsMatch(emailid);
            Console.WriteLine(result);
        }
        public const string MOBILE_NUMBER = @"[0-9]{2}\s+[1-9]{10}$";

        public void MobileNumber(string mobileno)
        {
            Regex regex = new Regex(MOBILE_NUMBER);
            bool result = regex.IsMatch(mobileno);
            Console.WriteLine(result);
        }
        public const string PASSWORD = @"[a-zA-Z]{8}$";
        public void Password(string password)
        {
            Regex regex = new Regex(PASSWORD);
            bool result = regex.IsMatch(password);
            Console.WriteLine(result);
        }

        public const string PASSWORDContain_1UPPERCASE = @"[A-Z]{1}[a-zA-Z]{7}$";

        public void PasswordUppercase(string uppercase)
        {
            Regex regex = new Regex(PASSWORDContain_1UPPERCASE);
            bool result = regex.IsMatch(uppercase);
            Console.WriteLine(result);
        }

        public const string PASSWORD_Numeric = @"[a-zA-Z][A-Z][0-9]+[a-zA-Z]$";

        public void PasswordNumeric(string numeric)
        {
            Regex regex = new Regex(PASSWORD_Numeric);
            bool result = regex.IsMatch(numeric);
            Console.WriteLine(result);
        }

        public const string PASSWORD_SPECIALCharacter = @"[a-zA-Z0-9]{1}[A-Z][0-9][@#$%&*_-]+[a-zA-Z0-9]$";
        public void PasswordSpeicalChar(string speical)
        {
            Regex regex = new Regex(PASSWORD_SPECIALCharacter);
            bool result = regex.IsMatch(speical);
            Console.WriteLine(result);
        }

    }

}
