namespace HW4
{
    internal class Task4
    {
        public static bool CalculateExpression(string expression)
        {
            // Розділяємо вираз на операнди і оператор
            string[] parts = expression.Split(' ');
            if (parts.Length != 3)
            {
                throw new FormatException("Invalid expression format.");
            }

            // Отримуємо операнди і оператор
            int operand1 = int.Parse(parts[0]);
            int operand2 = int.Parse(parts[2]);
            string op = parts[1];

            // Виконуємо порівняння залежно від оператора
            switch (op)
            {
                case ">":
                    return operand1 > operand2;
                case "<":
                    return operand1 < operand2;
                case ">=":
                    return operand1 >= operand2;
                case "<=":
                    return operand1 <= operand2;
                case "==":
                    return operand1 == operand2;
                case "!=":
                    return operand1 != operand2;
                default:
                    throw new FormatException("Invalid operator.");
            }
        }
    }
}
