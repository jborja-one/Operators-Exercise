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

//Tough Exercise
//int i = 3;
//int j = 4;
//int k = ++i * j++

//I think the answer is 16, because:
//prefix will increment i's value by one as soon as the code reaches it, and j++ will increment on the next loop (the next time it is run),
//by that thought, it would be 4 * 4, which will be 16.
