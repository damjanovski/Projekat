using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakBiblioteka
{
    class Knjiga
    {
        private string isbn;
        private string nazivKnjige;
        private string autorKnjige;
        private int godinaIzdanja;

        public Knjiga() { }

        public Knjiga(string isbn, string nazivKnjige, string autorKnjige, int godinaIzdanja)
        {
            if (isbn.Length == 13)
                this.isbn = isbn;
            else
                Console.WriteLine("Greska. Duzina isbn-a mora da bude 13 cifara.");
            this.nazivKnjige = nazivKnjige;
            this.autorKnjige = autorKnjige;
            if (godinaIzdanja >= 1)
                this.godinaIzdanja = godinaIzdanja;
            else
                Console.WriteLine("Greska. Godina izdanja mora biti veca od 0.");
        }

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (isbn.Length == 13)
                    isbn = value;
                else
                    Console.WriteLine("Greska. Duzina isbn-a mora da bude 13 cifara.");
            }
        }

        public string NazivKnjige
        {
            get { return nazivKnjige; }
            set { nazivKnjige = value; }
        }

        public string AutorKnjige
        {
            get { return autorKnjige; }
            set { autorKnjige = value; }
        }

        public int GodinaIzdanja
        {
            get { return godinaIzdanja; }
            set
            {
                if (godinaIzdanja >= 1)
                    godinaIzdanja = value;
                else
                    Console.WriteLine("Greska. Godina izdanja mora biti veca od 0.");
            }
        }
        public override string ToString()
        {
            return Ispis();
        }
        public string Ispis()
        {
            string sve;
            sve = "ISBN knjige: " + isbn + "\n Naziv knjige: " + nazivKnjige + "\n Autor knjige: " + autorKnjige + "\n Godina izdanja: " + godinaIzdanja;
            return sve;
        }
    }
}
