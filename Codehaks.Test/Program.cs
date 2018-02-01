using System;
using Codehaks.PersianDateTime;

namespace Codehaks.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToPersianDate : " + DateTime.Now.ToPersianDate());
            Console.WriteLine("ToPersianDateTime : " + DateTime.Now.ToPersianDateTime());
            Console.WriteLine("ToFullPersianDate : " + DateTime.Now.ToFullPersianDate());
            Console.WriteLine("ToFullPersianDateTime : " + DateTime.Now.ToFullPersianDateTime());

            Console.ReadLine();
        }
    }
}
