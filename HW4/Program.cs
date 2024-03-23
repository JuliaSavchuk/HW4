namespace HW4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------Task 1-------\n");
            Console.WriteLine("Select the conversion direction:");
            Console.WriteLine("1. Decimal to binary\n2. Binary to decimal\nEnter the option number: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 2)
            {
                Console.WriteLine("Incorrect input. Please enter 1 or 2.");
                Console.Write("Enter the option number: ");
            }
            switch (option)
            {
                case 1:
                    Task1.ConvertDecimalToBinary();
                    break;
                case 2:
                    Task1.ConvertBinaryToDecimal();
                    break;
            }

            Console.WriteLine("\n-------Task 2-------\n");
            Console.WriteLine("Enter a number from 0 to 9 with a word:");
            string input = Console.ReadLine();

            try
            {
                int result = Task2.ConvertWordToNumber(input);
                Console.WriteLine($"Entered number in numeric format: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n-------Task 3-------\n");
            try
            {
                // Створення нового закордонного паспорта з коректними даними
                ForeignPassport passport1 = new ForeignPassport("AB123456", "John Doe", new DateTime(2023, 10, 15));
                Console.WriteLine("The foreign passport has been successfully created.");

                // Спроба створення закордонного паспорта з некоректними даними
                ForeignPassport passport2 = new ForeignPassport("", "Jane Doe", DateTime.Now);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error has occurred: " + ex.Message);
            }

            Console.WriteLine("\n-------Task 4-------\n");
            Console.WriteLine("Enter a logical expression (for example, 3 > 2 or 7 < 3):");
            string expression = Console.ReadLine();

            try
            {
                bool result = Task4.CalculateExpression(expression);
                Console.WriteLine($"Result : {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid expression format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}