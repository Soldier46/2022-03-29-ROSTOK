using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_29_ROSTOK
{
    class Class1
    {
        public string megnezevezes { get; set; }
        public string Kategória { get; set; }
        public string Egység { get; set; }
        public double Rost { get; set; }


        public Class1(string sor)
        {
            string[] t = sor.Split(';');
            megnezevezes =(t[0]);
            Kategória = t[1];
            Egység = t[2];
            Rost = double.Parse(t[3]);

           


        }
    }
}
