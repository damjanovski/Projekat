using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakBiblioteka
{
    class Biblioteka
    {
        private static string nazivBiblioteke = "Gradska biblioteka u Novom Sadu";
        private static string adresaBiblioteke = "Dunavska 1";
        public  List<Knjiga> listaKnjiga = new List<Knjiga>();

        public static string PodaciOBiblioteci()
        {
            string sve;
            sve = "Naziv biblioteke: " + nazivBiblioteke + "\nAdresa biblioteke: " + adresaBiblioteke;
            return sve;
        }

        public string DodajKnjigu(string isbn, string nazivKnjige, string autorKnjige, int godinaIzdanja)
        {
            Knjiga knjiga = new Knjiga(isbn, nazivKnjige, autorKnjige, godinaIzdanja);
            if (listaKnjiga.Contains(knjiga))
                return "U biblioteci se vec nalazi knjiga za unesenim ISBN-om.";
            else
            {
                listaKnjiga.Add(knjiga);
                return "Dodata je nova knjiga.";
            }

        }

        public void PromeniKnjigu(string noviIsbn, string noviNaziv, string noviAutor, int novaGodina)
        {
            Console.WriteLine("Unesite ISBN knjige iz biblioteke koju zelite da promenite: ");
            string isbn = Console.ReadLine();
            foreach (Knjiga k in listaKnjiga)
            {
                if (k.Isbn == isbn)
                {
                    k.Isbn = noviIsbn;
                    k.NazivKnjige = noviNaziv;
                    k.AutorKnjige = noviAutor;
                    k.GodinaIzdanja = novaGodina;
                }
                else
                    Console.WriteLine("U biblioteci se ne nalazi knjiga sa unesenim ISBN-om.");
            }
        }

        public void ObrisiKnjigu(string isbn)
        {
            foreach (Knjiga k in listaKnjiga)
            {
                if (k.Isbn == isbn)
                    listaKnjiga.Remove(k);
                else
                    Console.WriteLine("U biblioteci ne postoji knjiga sa unesenim ISBN-om.");
            }
        }
    }
}
