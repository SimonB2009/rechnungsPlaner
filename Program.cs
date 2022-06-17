﻿using System;

namespace HelloWorld
{

     class Program  {

         static double totalSumme = 0;

         static void Main(string[] args) {

         //Console.OutputEncoding = System.Text.Endcoding.UTF8;

             anschreiben(); // go to the funktion anschreiben and show the epistle.
             showPrice("Bananen", 3, 3.30); // show the price of the product. 
             showPrice("Äpfel", 4, 1.35); // show the price of the product. 
             Console.WriteLine("Gesamsummet: " + totalSumme);
             Console.WriteLine("Versandkosten: " + versand() + "€");
        }

         static void anschreiben() {

             string name = "Herr Mayer";
             string date = DateTime.Now.ToString("dd-MM-yyyy");; // heutiges Datum

             Console.WriteLine("Hallo " + name + ",");
             Console.WriteLine("");
             Console.WriteLine("Hiermit sende ich ihre Rechnung vom " + date + ".");
             Console.WriteLine("");
             Console.WriteLine("Viele Grüße");
             Console.WriteLine("Simon Brandstetter");
         }

         static void showPrice(string product, int amount, double price) {
           
             double total = amount * price;

             Console.WriteLine("");
             Console.WriteLine("Produckt: " + product);
             Console.WriteLine("Menge: " + amount);
             Console.WriteLine("Preis: " + price + "€");
             Console.WriteLine("Summe: " + total + "€");
             Console.WriteLine("");
             totalSumme = totalSumme + total; 
         } 

         static double versand() {

            if(totalSumme > 20 ) {

                return 2.50;

            } else {

                return 0;
            }
         }
     }
}