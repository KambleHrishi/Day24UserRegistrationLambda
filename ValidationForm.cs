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
        public const string USER_FIRST_NAME = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
        public void ValidationFirstName(string firstname)
        {
            bool FirstName(string firstName) => (Regex.IsMatch(firstName, USER_FIRST_NAME));
        }
        public const string USER_LAST_NAME = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
        public void ValidationLastName(string lastname)
        {
            bool LastName(string lastName) => (Regex.IsMatch(lastName, USER_LAST_NAME));
        }
        public const string USEREMAIL_REGEX = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]";
        public void ValidationEmail(string email)
        {
            bool Email(string email) => (Regex.IsMatch(email, USEREMAIL_REGEX));
        }
        public const string USERPHONENUMBER_REGEX = @"[0-9]{2}\s+[1-9]{10}$";
        public void ValidationPhoneNumber(string phonenumber)
        {
            bool MobileNumber(string mobileNumb) => (Regex.IsMatch(mobileNumb, USERPHONENUMBER_REGEX));
        }
        public const string USERPASSWORD_REGEX = @"[a-zA-Z0-9]{1}[A-Z][0-9][@#$%&*_-]+[a-zA-Z0-9]$";
        public void ValidationPassword(string password)
        {
            bool Password(string password) => (Regex.IsMatch(password, USERPASSWORD_REGEX));
        }

    }

}
