namespace HW4
{
    internal class Task1
    {
        public static void ConvertDecimalToBinary()
        {
            Console.Write("Enter a number in the decimal system:");
            int decimalNumber;
            while (!int.TryParse(Console.ReadLine(), out decimalNumber))
            {
                Console.WriteLine("Incorrect input. Please enter an integer.");
                Console.Write("Enter a number in the decimal system:");
            }

            string binaryNumber = Convert.ToString(decimalNumber, 2);
            Console.WriteLine($"In the binary system: {binaryNumber}");
        }

        public static void ConvertBinaryToDecimal()
        {
            Console.Write("Enter a number in binary: ");
            string binaryInput = Console.ReadLine();

            int decimalNumber;
            try
            {
                decimalNumber = Convert.ToInt32(binaryInput, 2);
                Console.WriteLine($"In the decimal system: {decimalNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input. Please enter a valid binary number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The entered number exceeds the allowable range.");
            }
        }
    }
}
