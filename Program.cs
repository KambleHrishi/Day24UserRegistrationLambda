namespace Day24UserRegistrationLambda
{
    public class Program
    {
        public static void Main(string[]args)
        {
            ValidationForm form = new ValidationForm();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            form.FirstName(firstName);

            Console.WriteLine("Enter The Last Name: ");
            string lastName = Console.ReadLine();
            form.FirstName(lastName);

            Console.WriteLine("Enter valid email: ");
            string emaiId = Console.ReadLine();
            form.EmailID(emaiId);

            Console.WriteLine("Enter valid Mobile No: ");
            string MobileNo = Console.ReadLine();
            form.MobileNumber(MobileNo);

            Console.WriteLine("Enter valid Password: ");
            string pass = Console.ReadLine();
            form.Password(pass);

            Console.WriteLine("Enter Password Contain 1 Uppercase: ");
            string password = Console.ReadLine();
            form.Password(password);

            Console.WriteLine("Enter Password Contain 1 Numeric: ");
            string num = Console.ReadLine();
            form.PasswordNumeric(num);
        }
    }
}
