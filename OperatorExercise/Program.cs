namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The difference between {a} and {b} is {difference}");
            Console.WriteLine($"The product of {a} and {b} is {product}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter a radius for a circle:");
            var radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);

        }

        static void AreaOfCircle(double radius){
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius {radius} is {area}");
        }
    }
}
