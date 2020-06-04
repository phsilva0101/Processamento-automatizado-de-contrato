using System;
using System.Globalization;
using ProcessamentoAutomatizado.Entities;
using ProcessamentoAutomatizado.Services;

namespace ProcessamentoAutomatizado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write(" Enter number of installment: ");
            int n = int.Parse(Console.ReadLine());




        }
    }
}
