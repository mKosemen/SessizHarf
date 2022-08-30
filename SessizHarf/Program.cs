using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen metin giriniz.");
            string metin = Console.ReadLine();
            string[] veri = metin.Trim().Split(' ');
            bool[] bools = new bool[veri.Length];
            string sesliHarfler = "aeıioöuüAeIİOÖUÜ ";
            for (int i = 0; i < veri.Length; i++)
            {
                byte sayac = 0;
                char[] harf = veri[i].ToCharArray();
                for (int y = 0; y < veri[i].Length; y++)
                {
                    if (sesliHarfler.Contains(harf[y]))
                    {
                        sayac = 0;
                    }
                    else
                    {
                        sayac++;
                        if (sayac == 2)
                        {
                            bools[i] = true;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(", ", bools));
            Console.ReadLine();
        }
    }
}
