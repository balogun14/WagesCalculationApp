
// This a Program to calculte the gross pay , net pay and task deduction of a factory in Newark,US

/*
Requirements
Hourly Rate: $25,
Office Days: 5 days,
Minimum hour: 8hrs
*/

const int RATE = 25;
decimal tax;

Console.Write("How Many hours did you to work per day (minimum is 8 hours per day)? ");
int hoursOfWorking = Convert.ToInt32(Console.ReadLine());
if (hoursOfWorking >= 8)
{
    decimal dailySum = (decimal)(RATE * hoursOfWorking!);
    // System.Console.WriteLine(dailySum);

    // let us assume the month is 30 days so 30 * 5
    int numOfDaysInMonth = 20;
    decimal grossPay = numOfDaysInMonth * dailySum;

    // conditions to follow for task

    if (grossPay < 1500)
    {
        // tax is 2% which is 0.02
        tax = (decimal)2 / 100;
        decimal deduction = grossPay * tax;
        decimal netPay = grossPay - deduction;
        System.Console.WriteLine($"Gross Pay: ${grossPay} \nDeduction: ${deduction} \nNet Pay: ${netPay}");

    }
    else if (grossPay == 1500)
    {
        // tax is 5% which is 0.05
        tax = (decimal)5 / 100;
        decimal deduction = grossPay * tax;
        decimal netPay = grossPay - deduction;
        System.Console.WriteLine($"Gross Pay: ${grossPay} \nDeduction: ${deduction} \nNet Pay: ${netPay}");

    }
    if (grossPay >= 2250 && grossPay <= 2500)
    {
        tax = (decimal)10 / 100;
        decimal deduction = grossPay * tax;
        decimal netPay = grossPay - deduction;
        System.Console.WriteLine($"Gross Pay: ${grossPay} \nDeduction: ${deduction} \nNet Pay: ${netPay}");
    }
    else
    {
        // tax rate 15% which is 0.15
        tax = 0.15M;
        decimal deduction = grossPay * tax;
        decimal netPay = grossPay - deduction;
        System.Console.WriteLine($"Gross Pay: ${grossPay} \nDeduction: ${deduction} \nNet Pay: ${netPay}");
    }
}
else
{
    System.Console.WriteLine("you did not meet the requirement");
    System.Console.WriteLine("Minimum hours is 8 \nWork harder next time :) ");
}



// double result = 