namespace HW4
{
    internal class Task2
    {
        public static int ConvertWordToNumber(string word)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int index = Array.IndexOf(numbers, word.ToLower());

            if (index == -1)
            {
                throw new ArgumentException("The wrong word for a number has been entered.");
            }

            return index;
        }
    }
}
