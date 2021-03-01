using System;
using System.Globalization;

namespace translator_v2

{
    class Program
    {
        static void Main(string[] args)
        {
            Tool t = new Tool();

            t.GetLanguage();

            t.Translate("Tool123", t.language);
            t.Translate(113.40, 1145000.80, t.language);
            t.Translate(false, t.language);
            t.Translate((Type)t.GetType(), t.language);
        }
    }
}
