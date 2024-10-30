using Savarankiskas2.Core.Models;
using Savarankiskas2.Core.Repositories;
using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Savarankiskas2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepository fileRepository = new FileRepository("knygos.txt");

            List<Knyga> knygos = fileRepository.GautiKnygas();

            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Rodyti knygas pagal autoriu");
                Console.WriteLine("2. Rodyti knygas pagal metus");
                Console.WriteLine("3. Rodyti klasikos zanro knygas");
                Console.WriteLine("4. Baigti programa");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        Console.WriteLine("Iveskite autoriu:");
                        string autorius = Console.ReadLine();
                        foreach (Knyga a in knygos)
                        {
                            if(a.Autorius.Contains(autorius))
                            {
                                Console.WriteLine($"ID: {a.KnygosID}, Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.IsleidimoMetai}, Zanras: {a.Zanras}");
                            }
                        }
                        Console.WriteLine();
                        continue;
                    case 2:
                        Console.WriteLine("Iveskite metus:");
                        int metai = int.Parse(Console.ReadLine());
                        foreach (Knyga a in knygos)
                        {
                            if (metai >= a.IsleidimoMetai) //variantas spausdina visas knygas, išleistas nuo nurodytų metų. Jei norima knygų išleistų būtent nurodytais metais -> if (metai == a.IsleidimoMetai)
                            {
                                Console.WriteLine($"ID: {a.KnygosID}, Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.IsleidimoMetai}, Zanras: {a.Zanras}");
                            }
                        }
                        Console.WriteLine();
                        continue;
                    case 3:
                        foreach (Knyga a in knygos)
                        {
                            if (a.Zanras == "Classic")
                            {
                                Console.WriteLine($"ID: {a.KnygosID}, Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.IsleidimoMetai}, Zanras: {a.Zanras}");
                            }
                        }
                        Console.WriteLine();
                        continue;
                    case 4:
                        return;
                }
            }
        }
    }
}