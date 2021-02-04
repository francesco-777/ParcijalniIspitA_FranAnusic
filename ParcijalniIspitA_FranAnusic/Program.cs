using System;
using System.Collections.Generic;

namespace ParcijalniIspitA_FranAnusic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak1");
            Console.WriteLine("Upišite nekakav tekst:");
            string tekst = Console.ReadLine();
            string obrnuto = "";
            for(int i = tekst.Length - 1; i >= 0; i--)
            {
                obrnuto += tekst[i];
            }
            Console.WriteLine(obrnuto);

            Console.WriteLine("\n");
            Console.WriteLine("Zadatak2");

            Console.WriteLine("Unesite prirodni broj (za kraj unesite nulu):");

            int ulazniBroj = 0;
            int brojBrojeva23 = 0;
            int brojBrojeva2 = 0;
            int brojBrojeva3 = 0;
            int brojOstalih = 0;

            List<int> brojevi23 = new List<int>();
            List<int> brojevi2 = new List<int>();
            List<int> brojevi3 = new List<int>();
            List<int> ostali = new List<int>();

            while (true)
            {
                ulazniBroj = int.Parse(Console.ReadLine());
                if (ulazniBroj == 0)
                {
                    break;
                }
                else if (ulazniBroj < 0)
                {
                    Console.WriteLine("Broj nije prirodan!");
                }
                else if (ulazniBroj %2==0 && ulazniBroj %3==0)
                {
                    brojBrojeva23++;
                    brojevi23.Add(ulazniBroj);
                }
                else if (ulazniBroj % 2 == 0 && !(ulazniBroj % 3 == 0))
                {
                    brojBrojeva2++;
                    brojevi2.Add(ulazniBroj);
                }
                else if (!(ulazniBroj % 2 == 0) && ulazniBroj % 3 == 0)
                {
                    brojBrojeva3++;
                    brojevi3.Add(ulazniBroj);
                }
                else
                {
                    brojOstalih++;
                    ostali.Add(ulazniBroj);
                }
                
            }

            Console.WriteLine("Ukupno brojeva djeljivih s 2 i s 3: {0}", brojBrojeva23);
            Console.Write("Brojevi djeljivi s 2 i s 3:");
            for (int i = 0; i < brojevi23.Count; i++)
            {
                Console.Write(" " + brojevi23[i]);
            }

            Console.WriteLine("\nUkupno brojeva djeljivih s 2 (ali ne s 3): {0}", brojBrojeva2);
            Console.Write("Brojevi djeljivi s 2 (ali ne s 3):");
            for (int i = 0; i < brojevi2.Count; i++)
            {
                Console.Write(" " + brojevi2[i]);
            }

            Console.WriteLine("\nUkupno brojeva djeljivih s 3 (ali ne s 2): {0}", brojBrojeva3);
            Console.Write("Brojevi djeljivi s 3 (ali ne s 2):");
            for (int i = 0; i < brojevi3.Count; i++)
            {
                Console.Write(" " + brojevi3[i]);
            }

            Console.WriteLine("\nUkupno ostalih brojeva: {0}", brojOstalih);
            Console.Write("Ostali brojevi:");
            for (int i = 0; i < ostali.Count; i++)
            {
                Console.Write(" " + ostali[i]);
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("\nZadatak3");

            Ucenik uc = new Ucenik();
            Ucenik uc2 = new Ucenik();

            Console.WriteLine("Ime:");
            uc.Ime = Console.ReadLine();

            Console.WriteLine("Prezime:");
            uc.Prezime = Console.ReadLine();

            Console.WriteLine("Datum rođenja:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            uc.DatumRodjenja = d1;

            Console.WriteLine("Prosjek:");
            uc.Prosjek = double.Parse(Console.ReadLine());

            Console.WriteLine("Vaša starost je {0} god.", uc.Starost);

            Console.WriteLine(uc.ProsjekRijecima);

            Console.WriteLine("Promjenite datum rođenja:");

            uc.NaPromjenuDatumaRodjenja += new Ucenik.NaPromjenuDatumaRodjenjaDelegat(uc_NaPromjenuDatumaRodjenja);

            uc2.NaPromjenuDatumaRodjenja += new Ucenik.NaPromjenuDatumaRodjenjaDelegat(uc_NaPromjenuDatumaRodjenja);

            DateTime d2 = DateTime.Parse(Console.ReadLine());
            uc.DatumRodjenja = d2;

            static void uc_NaPromjenuDatumaRodjenja(object sender, EventArgs e)
            {
                Console.WriteLine("Učenik je promjenio podatke, datum rođenja je {0}", ((Ucenik)sender).DatumRodjenja.ToShortDateString() );
            }

            Console.WriteLine("Promijenjena starost je {0} god.", uc.Starost2);


            Console.WriteLine("\nIspis unešenog učenika:" +
                "\nIme: {0} \nPrezime: {1} \nDatum rođenja: {2} \nProsjek: {3} \nProsjek riječima: {4} \nStarost: {5}", uc.Ime,uc.Prezime,uc.DatumRodjenja.ToShortDateString(), uc.Prosjek,uc.ProsjekRijecima,uc.Starost);
        }
    }
}
