namespace Calculator

{
    class Model
    {
        public double AddOperation (double x, double y)
        { 
            return x + y; 
        }
        
        public double SubtractOperation(double x, double y)
        {
            return x - y;
        }

        public double MultiplyOperation(double x, double y)
        {
            return x * y;
        }

        public double DivideOperation(double x, double y)
        {
            if (y == 0)
            { 
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return x / y;
        }
    }
}
