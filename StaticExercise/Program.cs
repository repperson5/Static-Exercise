namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temp in Fahrenheit you want to convert?");
            var fahrTemp = Convert.ToDouble(Console.ReadLine());
            var convertToCel = TempConverter.FahrenheitToCelsius(fahrTemp);

            Console.WriteLine($"That equals {convertToCel} degrees Celsius");
            Console.WriteLine();

            Console.WriteLine("What is temperature in Celsius you want to convert?");
            var celTemp = Convert.ToDouble(Console.ReadLine());
            var convertToFahr = TempConverter.CelsiusToFahrenheit(celTemp);

            Console.WriteLine($"That equals {convertToFahr} degrees Fahrenheit");
            
        }
    }
}
