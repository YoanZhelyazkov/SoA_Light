using System;
using System.Collections.Generic;
using System.Text;

namespace SoA_Light
{
    static class User
    {
       public static string Name { get; set; }
       public static int Age { get; set; }
       public static int Weight { get; set; }
       public static int Strength { get; set; }
       public static List<string> SpokenLanguages = new List<string>();
    }
}
