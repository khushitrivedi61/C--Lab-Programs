using System;

class Program
{
    static void Main()
    {
        string password;
        bool valid = false;

        while (!valid)
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            if (password.Length >= 8)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        hasUpper = true;
                    else if (char.IsDigit(c))
                        hasDigit = true;
                    else if (!char.IsLetterOrDigit(c))
                        hasSpecial = true;
                }

                if (hasUpper && hasDigit && hasSpecial)
                {
                    valid = true;
                    Console.WriteLine("Password is valid");
                }
                else
                {
                    Console.WriteLine("Password must contain at least one uppercase letter, one digit and one special character");
                }
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long");
            }
        }
    }
}
