using System;
using ExercicioAbstract.Entities;
using System.Collections.Generic;

namespace ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());
                    System.Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());
                    System.Console.Write("Number of employees: ");
                    int num = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, num));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID:");
            foreach(Payer payer in list)
            {
                System.Console.WriteLine(payer.Name 
                    + ": $ "
                    + payer.Tax().ToString("F2"));
            }

            System.Console.WriteLine();
            double sum = 0;
            foreach(Payer payer in list)
            {
                sum += payer.Tax();
            }

            System.Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2"));
        }
    }
}
