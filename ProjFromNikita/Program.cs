namespace ProjFromNikita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = GetString("Enter your name");

            Console.WriteLine(name);

            var number = GetInt("Enter your number");

            Console.WriteLine(number);

            var array = GetIntArray("Enter your numbers", 5);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        static string GetString(string message)
        {            
            string result;

            do
            {
                Console.Write($"{message}: ");
                result = Console.ReadLine();
                result = result.Trim();
            }           
            while(string.IsNullOrWhiteSpace(result));
           
            return result;
        }

        static int GetInt(string message)
        {
            int result;
            bool parseResult;

            do
            {
                Console.Write($"{message}: ");
                parseResult = int.TryParse(Console.ReadLine(), out result);
            }
            while (!parseResult);

            return result;
        }

        static int[] GetIntArray(string message, int count)
        {
            var array = new int[count];
            bool parseResult;

            Console.WriteLine($"{message}: ");

            for (int i = 0; i < count; i++)
            {             
                do
                {
                    Console.Write($"Enter {i + 1} of {count}: ");
                    parseResult = int.TryParse(Console.ReadLine(), out array[i]);
                }
                while (!parseResult);
            }
            return array;
        }

        static int[] ChangeArray()
    }
}
