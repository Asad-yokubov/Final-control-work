using System;

class Program
{
    static void Main()
    {
        string[] inputArray = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"}; 

        int maxLength = 3;
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= maxLength)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= maxLength)
            {
                resultArray[index] = str;
                index++;
            }
        }

        Console.WriteLine("Массив строк с длиной меньше или равной 3 символам:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
} 