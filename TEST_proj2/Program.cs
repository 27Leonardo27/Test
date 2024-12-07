namespace TEST_proj2
{
    internal class Program  //Генератор пароля 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Login: ");
            Console.ReadLine();

            Console.Write("Enter your password lenght: ");
            var length = int.Parse(Console.ReadLine());

            string password = PasswordGenerator.GetPassword(length);

            Console.Write("==============================\n Your password is:       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(password);
            Console.ResetColor();
            Console.WriteLine("\n==============================");
        }

        class PasswordGenerator
        {
            static string chars = "abcdefgehjkuytropzxcvbnml:;'|<>{}%^&*()[]_!=+?1234567890";

            public static string GetPassword(int length)
            {                
                var random = new Random();

                string password = "";
               
                for (var i = 0; i < length; i++)
                {                   
                    var index = random.Next(chars.Length);
                    password += chars[index].ToString();
                }
                
                return password;
            }
        }
    }
}
