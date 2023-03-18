using System;

delegate double Deleg(ref double wage, ref double socialFee, ref  double clean);

namespace Lesson6
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double wage = 0, tax = 0, clean = 0, stampDuty = 0, socialFee = 0;
            Console.WriteLine("Type 1 For Wage to Clean   Type 2 For Clean to Wage");

            Console.Clear();
            Console.WriteLine("Type the Wage Salary");

            Taxes(out wage, out tax);
            Deleg deleg = new Deleg(Socialfee);
            deleg += Stampduty;
            deleg(ref wage, ref stampDuty, ref clean);
           // Socialfee(ref wage, ref socialFee, ref clean);
           // Stampduty(ref wage, ref stampDuty, ref clean);
            CleanBalance(ref wage, ref socialFee, ref stampDuty, ref clean, ref tax);




            Console.WriteLine("Taxes          " + (int)tax);
            Console.WriteLine("Social Fee     " + (int)socialFee);
            Console.WriteLine("Stamp Duty     " + (int)stampDuty);
            Console.WriteLine("Wage Balance   " + (int)wage);
            Console.WriteLine("Clean Balance  " + (int)clean);
        }

        public static double CleanBalance(ref double wage, ref double socialFee, ref double stampDuty, ref double clean, ref double tax)
        {
            clean = wage - socialFee - stampDuty - tax;
            return clean;
        }

        public static double Stampduty(ref double wage, ref double stampDuty, ref double clean)
        {
            if (wage <= 100000)
                stampDuty = 1500;
            else if (wage > 100000 && wage <= 200000)
                stampDuty = 3000;
            else if (wage > 200000 && wage <= 500000)
                stampDuty = 5500;
            else if (wage > 500000 && wage <= 1000000)
                stampDuty = 8500;
            else if (wage > 1000000)
                stampDuty = 15000;

            return stampDuty;
        }

        public static double Socialfee(ref double wage, ref double socialFee, ref double clean)
        {
            if (wage <= 500000)
                socialFee = wage / 100 * 5;
            else if (wage > 500000 && wage <= 1125000)
                socialFee = (wage / 100 * 10) - 25000;
            else if (wage > 1125000)
                socialFee = 87500;

            return socialFee;
        }

        public static double Taxes(out double wage, out double tax)
        {
            if (double.TryParse(Console.ReadLine(), out wage))
            {
                if (wage < 2000)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR:Number must be greater/equal to 2000");
                    Taxes(out wage, out tax);
                }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR:Not a number");
                Taxes(out wage, out tax);
            }

            tax = wage / 100 * 20;
            return tax;

        }
    }
}