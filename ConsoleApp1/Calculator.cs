namespace ConsoleApp1

{
    public class Calculator
    {
        private double a;
        private double b;
        private string operation;
        
        public Calculator(double a, double b, string operation)
        {
            this.a = a;
            this.b = b;
            this.operation = operation;
        }
        
        public double Execute()
        {
            return operation switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => Divide(),
                _ => throw new InvalidOperationException("Invalid operation"),
            };
        }
        
        private double Divide()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }
    }
}