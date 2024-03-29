﻿namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposite, withrawal;

            do
            {
                Console.Write("Deposite (1-2000): ");
                deposite = double.Parse(Console.ReadLine());
                Console.Write("Withdrawal (1-2000): ");
                withrawal = double.Parse(Console.ReadLine());
                if (deposite >= 1 && deposite <= 2000)
                {
                    if(withrawal >= 1 && withrawal <= 2000)
                    {
                        break;
                    }
                }
                Console.WriteLine("Input should be 1-2000 only!");
            } while (true);

            compute(deposite, withrawal);
        }

        static double compute(double deposite, double withrawal)
        {
            double output = deposite;   
            if (check(deposite,withrawal)) 
            {
                output = (deposite - withrawal) - .5;
                Console.WriteLine($"Output: {output}");
            }
            return output;
        }

        static bool check(double deposite, double withrawal)
        {
            if (withrawal > deposite)
            {
                Console.WriteLine($"Output: {deposite}");
                Console.WriteLine("Insufficient Funds");
                return false;
            }
            else if(withrawal % 5 != 0)
            {
                Console.WriteLine($"Output: {deposite}");
                Console.WriteLine("Incorrect Withdrawal Amount (not multiple of 5)");
                return false;
            }
            return true;
        }
    }
}