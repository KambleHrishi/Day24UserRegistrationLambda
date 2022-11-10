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
        }
    }
}
