using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_29_ROSTOK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> lista = new List<Class1>();
            foreach (var Bármitbeirhatok in File.ReadAllLines("rostok.txt").Skip(1))
            {
                lista.Add(new Class1(Bármitbeirhatok));
            }
            Console.WriteLine($"3.feladat: Élelmiszerek száma: { lista.Count}");

            int vizsgalat = 0;

            foreach (var i in lista)
            {
                if (i.Egység != "100g")
                {
                    vizsgalat++;
                }
            }
            Console.WriteLine($"4.feladat : Nem 100g-os egység :  {vizsgalat}");

            vizsgalat = 0;
            double rosttartalom = 0;
            foreach (var i in lista)
            {
                if (i.Egység == "100g" && i.Kategória == "Friss gyümölcsök")
                {
                    vizsgalat++;
                    rosttartalom += i.Rost;
                }
            }
            Console.WriteLine($"5.feladat : Ennyi friss 100g-os gyümölcs volt {rosttartalom/vizsgalat}");

            Console.WriteLine($"7.feladat Ennyi kategória van {lista.GroupBy(x => x.Kategória).Count()}");

            int aszalt = 0;
            int friss = 0;
            int gab = 0;
            int zöld = 0;
            int mag = 0;

            foreach (var i in lista)
            {
                if (i.Kategória == "Aszalt gyümölcsök")
                {
                    aszalt++;
                }
                if (i.Kategória == "Friss gyümölcsök")
                {
                    friss++;
                }
                if (i.Kategória == "Gabonák és lisztek")
                {
                    gab++;
                }
                if (i.Kategória == "Zöldségek")
                {
                    zöld++;
                }
                if (i.Kategória == "Magvak")
                {
                    mag++;
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            Console.WriteLine($"\t Aszalt gyümölcsök - {aszalt}");
            Console.WriteLine($"\t Friss gyümölcsök - {friss}");
            Console.WriteLine($"\t Gabonák és lisztek - {gab}");
            Console.WriteLine($"\t Zöldségek - {zöld}");
            Console.WriteLine($"\t Magvak - {mag}");


            Console.WriteLine("9.feladat: Rostok100g.txt");
            StreamWriter valami = File.CreateText("Rostok100g.txt");
            valami.WriteLine("Megnevezés;Kategória,Rost");

            foreach (var i in lista)
            {
                if (i.Egység == "100g")
                {
                    valami.WriteLine($"{i.megnezevezes}; {i.Kategória};{ i.Rost}");
                }
            }
        }
    }
}
