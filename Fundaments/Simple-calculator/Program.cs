namespace Simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SWITCHES
            // simple calculator with switches
            //quick validation
            Console.WriteLine("This is simple calculator");
            Console.WriteLine("Please type your first value: ");
            if (!double.TryParse(Console.ReadLine(), out double firstNum))
            {
                Console.WriteLine("Wrong first input");
                return;
            }
            Console.WriteLine("Please type your second value:");
            if (!double.TryParse(Console.ReadLine(), out double secondNum))
            {
                Console.WriteLine("Wrong second input");
                return;
            }
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("Type operation: (addition/substraction/multiplication/division/squareroot/power)");
            string? choice = Console.ReadLine();
            double addition = firstNum + secondNum;
            double substraction = firstNum - secondNum;
            double multiplication = firstNum * secondNum;
            double division = Math.Round(firstNum / secondNum, 2);
            double firstNumSquareRoot = Math.Sqrt(firstNum);
            double secondNumSquareRoot = Math.Sqrt(secondNum);
            double power = Math.Pow(firstNum, secondNum);

            //using simple switch
            switch (choice)
            {
                case "addition":
                    Console.WriteLine($"Addition: {addition}");
                    break;
                case "substraction":
                    Console.WriteLine($"Substraction: {substraction}");
                    break;
                case "multiplication":
                    Console.WriteLine($"Multiplication: {multiplication}");
                    break;
                case "division":
                    Console.WriteLine($"Division: {division}");
                    break;
                case "square":
                    Console.WriteLine($"Square root from first number: {firstNumSquareRoot}" +
                        $"\nSquare root from second number: {secondNumSquareRoot}");
                    break;
                case "power":
                    Console.WriteLine($"Power: {power}");
                    break;
                default:
                    Console.WriteLine($"All basic operations: " +
                        $"\nAddition: {addition}" +
                        $"\nSubstraction: {substraction}" +
                        $"\nMultiplication: {multiplication}" +
                        $"\nDivision: {division}" +
                        $"\nSquare from first number: {firstNumSquareRoot}" +
                        $"\nSquare from second number: {secondNumSquareRoot}" +
                        $"\nPower: {power}");
                    break;
            }
        }
    }
}
