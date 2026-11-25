using System;

class Program
{
    static string DecimalToBinary(int number)
    {
        // 1. Handle zero explicitly
        if (number == 0)
        {
            return "0";
        }

        // 2. Track if negative and convert to positive long (avoids int.MinValue overflow)
        bool isNegative = number < 0;
        long value = Math.Abs((long)number);

        string binary = "";

        // 3. Extract bits using a while loop
        while (value > 0)
        {
            long remainder = value % 2;
            binary = remainder + binary;
            value /= 2;
        }

        // 4. Reattach the minus sign if the original number was negative
        return isNegative ? "-" + binary : binary;
    }

    static void Main()
    {
        int[] testNumbers = { 0, 13, -13, 255, int.MinValue };

        foreach (int num in testNumbers)
        {
            Console.WriteLine($"{num,12} -> {DecimalToBinary(num)}");
        }
    }
}

