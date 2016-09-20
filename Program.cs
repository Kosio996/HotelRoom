using System;

class Program
{
    static void Main()
    {
        var month = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        if (month == "May" || month == "October")
        {
            if (n <= 7)
            {
                var studio = 50 * n;
                var appartment = 65 * n;
                Console.WriteLine("Apartment: {0:f2} lv.", appartment);
                Console.WriteLine("Studio: {0:f2} lv.", studio);
            }
            if (n > 7 && n < 14)
            {
                var studio = 50 * 0.05;
                var result = (50 - studio) * n;
                Console.WriteLine("Apartment: {0:f2} lv." , n * 65);
                Console.WriteLine("Studio: {0:f2} lv." , result);
            }
            else if (n > 14)
            {
                var studio = 50 * 0.3;
                var result = (50 - studio) * n;
                var appartment = 65 * 0.1;
                var appRes = (65-appartment) * n;
                Console.WriteLine("Apartment: {0:f2} lv." , appRes);
                Console.WriteLine("Studio: {0:f2} lv." , result);
            }        
            
        }
        if (month == "June" || month == "September")
        {
            if (n > 14)
            {
                var studio = 75.20 * 0.2;
                var result = (75.20 - studio) * n;
                var appartment = 68.70 * 0.1;
                var appRes = (68.70 - appartment) * n;
                Console.WriteLine("Apartment: {0:f2} lv." , appRes);
                Console.WriteLine("Studio: {0:f2} lv." , result);
            }
            if (n <= 14)
            {
                var studio = 75.20 * n;
                var appartment = 68.70 * n;
                Console.WriteLine("Apartment: {0:f2} lv.", appartment);
                Console.WriteLine("Studio: {0:f2} lv.", studio);

            }
        }
        if (month == "August" || month == "July")
        {
            if (n <= 14)
            {
                var studio = 76 * n;
                var appartment = 77 * n;
                Console.WriteLine("Apartment: {0:f2} lv.", appartment);
                Console.WriteLine("Studio: {0:f2} lv.", studio);
            }
            if (n > 14)
            {
                var studio = 76 * n;
                var appartment = 77 * 0.1;
                var appRes = (77 - appartment) * n;
                Console.WriteLine("Apartment: {0:f2} lv.", appRes);
                Console.WriteLine("Studio: {0:f2} lv.", studio);
            }
            
        }
    }
}

