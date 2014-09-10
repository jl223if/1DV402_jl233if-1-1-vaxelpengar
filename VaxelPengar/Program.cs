using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxelPengar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variabler


            double subtotal = 0; // 371.38
            uint total = 0; //371 avrundat
            double roundingOffAmount = 0; //-0.38
            int cash = 0;                   // ca 1000
            int back = 0;               // 1000-371 = 629
            int numberOfCash = 0;           // 1 1 1 1 4
            bool testValue = true;

            //  ta in värden totalsumma
            while (testValue == true)
            {

                try
                {
                    Console.Write("ange totalsumma     :");
                    subtotal = double.Parse(Console.ReadLine());

                    testValue = false;
                    if (subtotal < 0.5)
                    {
                        testValue = true;
                        Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktikt värde");
                    Console.ResetColor();
                }
            }
            // Tar in värdet av erhållet belopp
            testValue = true;
            while (testValue == true)
            {
                try
                {
                    Console.Write("Ange erhåller Belopp:");
                    cash = int.Parse(Console.ReadLine());
                    testValue = false;
                    if (subtotal > cash)
                    {
                        testValue = true;
                        Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktigt Värde");
                }
            }
            //Beräkningar



            total = (uint)Math.Round(subtotal);
            roundingOffAmount = total - subtotal;
            back = cash - (int)total;

            //KVITTO

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total            :   {0, 20:c}", subtotal);
            Console.WriteLine("Öresavrundning   :   {0, 20:c}", roundingOffAmount);
            Console.WriteLine("Att Betala       :   {0, 20:c} ", total);
            Console.WriteLine("kontant          :   {0, 20:c}", cash);
            Console.WriteLine("Tillbaka         :   {0, 20:c}", back);
            Console.WriteLine("-------------------------------------------");


            //Uppdeling av sedalar

            numberOfCash = back / 500;
            back = back % 500;
            if (numberOfCash > 0)
            {
                Console.WriteLine("500-lappar      : {0}", numberOfCash);
            }
            numberOfCash = back / 100;
            back = back % 100;
            if (numberOfCash > 0)
            {
                Console.WriteLine("100-lappar      : {0}", numberOfCash);
            }
            numberOfCash = back / 20;
            back = back % 20;
            if (numberOfCash > 0)
            {
                Console.WriteLine("20-lappar       : {0}", numberOfCash);
            }
            numberOfCash = back / 5;
            back = back % 5;
            if (numberOfCash > 0)
            {
                Console.WriteLine("5-Mynt          : {0}", numberOfCash);
            }
            numberOfCash = back / 1;
            back = back % 1;
            if (numberOfCash > 0)
            {
                Console.WriteLine("1-Mynt          : {0}", numberOfCash);
            }
        }
    }
}
