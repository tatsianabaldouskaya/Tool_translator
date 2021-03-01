using System;

namespace translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool t = new Tool();

            t.GetLanguage();
            if (t.language == "EN")
            {
                t.Translate("Tool_123", (TypeEN)t.GetParameters(), "EN");
            }
            else if (t.language == "DE")
            {
                t.Translate("Werkzeug_123", (TypeDE)t.GetParameters(), "DE");
            }
            else
            {
                Console.WriteLine("Unsupported language");
            }



        }
    }
}
