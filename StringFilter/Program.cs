using System;

class Program
{
    static void Main()
    {
        string[] inputArray = { "Hello", "2", "world", ":-)" };
        
        int count = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3) count++;
        }
        
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                resultArray[index] = s;
                index++;
            }
        }
        
        Console.WriteLine("Результат: [" + string.Join(", ", resultArray) + "]");
    }
}