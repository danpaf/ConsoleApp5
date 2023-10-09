using System;
using ConsoleApp5;
using DayOfWeek = ConsoleApp5.DayOfWeek;

class Program
{
    static void Main(string[] args)
    {
        int xx = 10;
        int yx = 2; 
        int z = xx / yx; 
        Console.WriteLine(z);
        
        int x = 5; 
        Console.WriteLine(x);
        
        string s = "123"; 
        int y = int.Parse(s);
        Console.WriteLine(y);
        //Работа с цветом
        Color color = Color.Red;
        string hexCode = ColorUtility.GetHexCode(color);
        Console.WriteLine(hexCode);
        //Работа с датой
        DayOfWeek day = DayOfWeek.Monday;
        DayOfWeekUtility.PrintDayInRussian(day);
        //Работа с операциями
        int a = 10;
        int b = 5;
        Operation operation = Operation.Add;
        int result = Calculator.PerformOperation(a, b, operation);
        Console.WriteLine(result);
    }
}