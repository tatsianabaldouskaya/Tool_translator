using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace translator
{
    class Tool
    {
        public string language;
        string specifier;
        CultureInfo culture;
        // string name;
        public double length;
        public double radius;
        public bool cooling = true;




        public int GetParameters()
        {
            Console.WriteLine("Enter length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius:");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter tool type number (1-6):");
            int tooltype = int.Parse(Console.ReadLine());
            return tooltype;
        }
        public string GetLanguage()
        {
            Console.WriteLine("Select language: EN/DE");
            language = Console.ReadLine();
            return language;
        }
       

        public void Translate(string name, TypeEN type, string language)
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Type = {type}");

            specifier = "G";
            culture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine($"Length = {length.ToString(specifier, culture)} mm");

            Console.WriteLine($"Radius = {radius.ToString(specifier, culture)} mm");
            Console.WriteLine($"Cooling = {cooling}");
        }



        public void Translate(string name, TypeDE type, string language)
        {
                Console.WriteLine($"der Name = {name}");
                Console.WriteLine($"die Art = {type}");
                specifier = "G";
                culture = CultureInfo.CreateSpecificCulture("de-DE");

                Console.WriteLine($"die Länge = {length.ToString(specifier, culture)} mm");

                Console.WriteLine($"der Radius = {radius.ToString(specifier, culture)} mm");

                Console.WriteLine($"die Kühlung = {cooling}");
        }
                
            
            
      



    }
}
