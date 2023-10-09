namespace ConsoleApp5
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class Calculator
    {
        public static int PerformOperation(int a, int b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return a + b;
                case Operation.Subtract:
                    return a - b;
                case Operation.Multiply:
                    return a * b;
                case Operation.Divide:
                    if (b != 0)
                        return a / b;
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        return 0;
                    }
                default:
                    Console.WriteLine("Неизвестная операция.");
                    return 0; 
            }
        }
    }
}