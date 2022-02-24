using System;

namespace CalculateHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual horário que parou de trabalhar: ");
            Console.WriteLine("Hora: ");
            int horaParada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minuto: ");
            int minutoParada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Qual horário voltou a trabalhar: ");
            Console.WriteLine("Hora: ");
            int horaVolta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minuto: ");
            int minutoVolta = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;

            TimeSpan timeSpan = DateTime.Now.Subtract(new DateTime(today.Year, today.Month, today.Day, horaVolta, minutoVolta, 00));
            Console.WriteLine($"Saldo: {timeSpan.ToString()}");

            DateTime dateTime = new DateTime(today.Year, today.Month, today.Day, horaParada, minutoParada, 00).AddTicks(timeSpan.Ticks);

            Console.WriteLine();
            Console.WriteLine($"Nova hora final de trabalho: {dateTime:HH:mm}");
            Console.ReadKey();
        }
    }
}
