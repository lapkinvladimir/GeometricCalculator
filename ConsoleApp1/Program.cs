namespace ConsoleApp1

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator add = new Calculator(5, 10, "+");
            Console.WriteLine("Addition:");
            Console.WriteLine($"Result: {add.Execute()}");
            Console.WriteLine();
            
            Calculator subtract = new Calculator(10, 4, "-");
            Console.WriteLine("Subtraction:");
            Console.WriteLine($"Result: {subtract.Execute()}");
            Console.WriteLine();
            
            Calculator multiply = new Calculator(6, 3, "*");
            Console.WriteLine("Multiplication:");
            Console.WriteLine($"Result: {multiply.Execute()}");
            Console.WriteLine();
            
            Calculator divide = new Calculator(12, 4, "/");
            Console.WriteLine("Division:");
            Console.WriteLine($"Result: {divide.Execute()}");
            Console.WriteLine();
        }
    }
}