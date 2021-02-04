using System;

namespace ParcijalniIspitA_FranAnusic
{
    internal class Ucenik
    {

        public string Ime { get; internal set; }
        public string Prezime { get; internal set; }
        public double Prosjek { get; internal set; }

        public int Starost
        {
            get
            {
                DateTime d1 = DateTime.Now;
                TimeSpan ts = d1.Subtract(DatumRodjenja);
                return ts.Days / 365;
            }

        }

        public string ProsjekRijecima
        {
            get
            {
                if (Prosjek < 2)
                {
                    return "Prosjek je nedovoljan!";
                }
                else if (Prosjek < 2.5)
                {
                    return "Prosjek je dovoljan!";
                }
                else if (Prosjek < 3.5)
                {
                    return "Prosjek je dobar!";
                }
                else if (Prosjek < 4.5)
                {
                    return "Prosjek je vrlo dobar!";
                }
                else
                {
                    return "Prosjek je odličan!";
                }
            }
        }


        private DateTime d2;

        public DateTime DatumRodjenja
        {
            get => d2;
            set
            {
                d2 = value;
                if (NaPromjenuDatumaRodjenja != null)
                {
                    NaPromjenuDatumaRodjenja(this, new System.EventArgs());
                }
            }
        }


        public delegate void NaPromjenuDatumaRodjenjaDelegat(object sender, EventArgs e);
        public event NaPromjenuDatumaRodjenjaDelegat NaPromjenuDatumaRodjenja;

        public int Starost2
        {
            get
            {
                DateTime d2 = DateTime.Now;
                TimeSpan ts2 = d2.Subtract(DatumRodjenja);
                return ts2.Days / 365;
            }

        }
    }
}  
    
