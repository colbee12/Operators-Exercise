namespace OperatorExercise
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int add = a + b;
            int  sub = a - b;
            int  mul = a * b;
            int  quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            
            Console.WriteLine("what is the radius of the circle");
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = AreaOfCircle(radius);
            Console.WriteLine($"the area the circle with a radius of {radius} is {areaOfCircle}");
            
            
            
            
            
            
            
            
            
        }
        public static double AreaOfCircle(double radius)
        { 
            return Math.PI * radius * radius;   
        }
    }
}
