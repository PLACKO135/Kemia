using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozat
{
    class Program
    {
       static List<Kemia> lista = new List<Kemia>();
        static void Main(string[] args)
        {
            //1.

            StreamReader sr = new StreamReader("felfedezesek.csv");

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var adatok = sr.ReadLine().Split(';');

                Kemia uj = new Kemia(adatok[0],adatok[1],adatok[2],int.Parse(adatok[3]),adatok[4]);
            }
            sr.Close();

            //3
            int elemszam = lista.Count();
            Console.WriteLine($"3.feladat: Elemek száma: {elemszam}");

            //4

            int okori = lista.Where(x=>x.Ev =="Ókor" ).Count();

            //5
           
            string bekert="";
            while(!(bekert.Length==1||bekert.Length==2))
            {
                bekert=Console.ReadLine();
            }


            //6


            if (lista.Any(x=>x.Vegyjel==bekert))
            {
                Console.WriteLine("Keresés");
                Console.WriteLine($"\t Az elem vegyjele:{}");
                Console.WriteLine($"\t Az elem neve:{}");
                Console.WriteLine($"\t Rendszáma:{}");
                Console.WriteLine($"\t Felfedezés éve:{}");
                Console.WriteLine($"\t Felfedező:{}");
            }
            else
            {
                Console.WriteLine("Nincs ilyen elem az adatforrásban!");
            }


            //7
            int elteltev=0;
            Console.WriteLine($"{elteltev} év volt a leghosszabb időszak két felfedezés között.");

            //8

        }
    }
}
