namespace task1_array_statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tasks
            //1. Print the highest and lowest temperature
            //2. Count how many days were hot > 25C
            //3. Build a new array containing only the hot days temperatures
            //4. Calculate the average temperature
            //5. Print which day (index) had the highest temperature
            //rule: only two loops

            double[] temperatures = { 22.5, 19.0, 25.3, 30.1, 18.7, 27.4, 21.0 };
            double highestValue=double.NegativeInfinity;
            double lowestValue=double.PositiveInfinity;
            int hotDaysCount = 0;
            double averageTemperature = 0.0;
            int highestTemperatureIndex = 0;

            for (int i=0; i < temperatures.Length; i++)
            {
                //1 and 5
                if (highestValue < temperatures[i])
                {
                    highestValue = temperatures[i];
                    highestTemperatureIndex = i;
                }
                    if (lowestValue > temperatures[i]) lowestValue=temperatures[i];

                //2 
                if (temperatures[i] > 25)
                    hotDaysCount++;

                //4 
                averageTemperature += temperatures[i];
            }

            //3
            double[] hotDays = new double[hotDaysCount];
            int hotDaysIndex = 0;
            for (int i=0;i < temperatures.Length; i++)
            {
                if (temperatures[i] > 25)
                {
                    hotDays[hotDaysIndex] = temperatures[i];
                    hotDaysIndex++;
                }
            }

            Console.WriteLine($"Highest value: {highestValue}\nLowest value: {lowestValue}");
            Console.WriteLine($"How many days were hot >25C: {hotDaysIndex}");
            Console.WriteLine($"Average temperature: {averageTemperature / temperatures.Length:F}");
            foreach (double hotDay in hotDays)
            {
                Console.WriteLine($"These days were hot: {hotDay}");
            }
            Console.WriteLine($"Highest temperature index: {highestTemperatureIndex}");


        }
    }
}
