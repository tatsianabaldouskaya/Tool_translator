using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace translator_v2
{
    class Tool
    {
        public string language;
        CultureInfo culture;
        public double length;
        public double radius;
        public bool cooling;



        public int GetType()
        {

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

        public void Translate(double length, double radius, string language)
        {
            if (language == "EN")
            {
                culture = CultureInfo.CreateSpecificCulture("en-US");
                Console.WriteLine($"Length = {length.ToString(culture)} mm");
                Console.WriteLine($"Radius = {radius.ToString(culture)} mm");
            }
            else if (language == "DE")
            {
                culture = CultureInfo.CreateSpecificCulture("de-DE");
                Console.WriteLine($"die Länge = {length.ToString(culture)} mm");
                Console.WriteLine($"der Radius = {radius.ToString(culture)} mm");
            }
            else
                Console.WriteLine("Unsupported language");

        }



        public void Translate(bool cooling, string language)
        {
            if (language == "EN")
            {
                if (cooling == true)
                    Console.WriteLine("With cooling");
                else
                    Console.WriteLine("Without cooling");
            }

            else if (language == "DE")
            {
                if (cooling == true)
                    Console.WriteLine("mit Kühlung");
                else
                    Console.WriteLine("ohne Kühlung");
            }
            else
                Console.WriteLine("Unsupported language");
        }

        public void Translate(string name, string language)
        {
            if (language == "EN")
            {
                Console.WriteLine($"Name = {name}");
            }

            else if (language == "DE")
            {
                Console.WriteLine($"der Name ={name}");
            }
            else
                Console.WriteLine("Unsupported language");
        }

        public void Translate(Type type, string language)
        {
            if (language == "EN")
            {             
                Console.WriteLine($"Type = {type}");
                
            }
            else if (language == "DE")
            {
                switch (type)
                {
                    case Type.SphereMill:
                        Console.WriteLine($"die Art = {TypeDE.KugelFräser}");
                        break;
                    case Type.EndMill:
                        Console.WriteLine($"die Art = {TypeDE.SchaftFräser}");
                        break;
                    case Type.Facemill:
                        Console.WriteLine($"die Art = {TypeDE.ScheibenFräser}");
                        break;
                    case Type.CenterDrill:
                        Console.WriteLine($"die Art = {TypeDE.ZentrierBohrer}");
                        break;
                    case Type.ReamerDrill:
                        Console.WriteLine($"die Art = {TypeDE.ReibahleBohrer}");
                        break;
                    case Type.TaperDrill:
                        Console.WriteLine($"die Art = {TypeDE.KegelBohrer}");
                        break;

                }
                
            }
            else
                Console.WriteLine("Unsupported language");

        }


    }
          
     
}
