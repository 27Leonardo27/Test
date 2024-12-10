using System.Diagnostics;

namespace TEST_proj2;

internal class Program  
{
    static void Main(string[] args)  //Генератор пароля 
    {
        do 
        {
            Console.Write("\n\nEnter '1' for continue or '2' for exit: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Write("Enter your Login: ");
                        Console.ReadLine();

                        Console.Write("Do you want to use lowercase letters? Enter '1' for YES or '2' for NO: ");
                        if(Console.ReadLine() == "1")
                        {
                            PasswordGenerator.chars += "abcdefgehjkuytropzxcvbnml";
                        }
                        
                        Console.Write("Do you want to use uppercase letters? Enter '1' for YES or '2' for NO: ");
                        if(Console.ReadLine() == "1")
                        {
                            PasswordGenerator.chars += "ABCDEFGEHJKUYTROPZXCVBNML";
                        }
                       
                        Console.Write("Do you want to use numbers? Enter '1' for YES or '2' for NO: ");
                        if( Console.ReadLine() == "1")
                        {
                            PasswordGenerator.chars += "1234567890";
                        }

                        Console.Write("Do you want to use symbols? Enter '1' for YES or '2' for NO: ");
                        if(Console.ReadLine() == "1")
                        {
                            PasswordGenerator.chars += "%&!=*#?@";
                        }

                        Console.Write("Enter your password lenght: ");
                        var length = int.Parse(Console.ReadLine());

                        string password = PasswordGenerator.GetPassword(length);

                        Console.Write("==============================\nYour password is:       ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(password);
                        Console.ResetColor();
                        Console.WriteLine("\n==============================");
                        break;
                    }
                case "2":
                    {
                        return;
                    }
            }

        }
        while (true);
    }
}



class PasswordGenerator
{
    public static string chars = "";

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
