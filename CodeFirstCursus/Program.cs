using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VDABContext>());

            using (var context = new VDABContext())
            {
                var jean = new Instructeur { Voornaam = "Jean", Familienaam = "Smits", Wedde = 1000, InDienst = new DateTime(1994, 8, 1),
                    HeeftRijbewijs =true, Address = new Address { Straat = "Jansstraat", HuisNr = "2", PostCode = "3000", Gemeente = "Leuven" } };

                context.Instructeurs.Add(jean);
                context.Cursussen.Add(new KlassikaleCursus { Naam = "Frans in 24u", StartDatum = new DateTime(2018, 7, 1), EindDatum = new DateTime(2018, 7, 1) });
                context.Cursussen.Add(new ZelfstudieCursus { Naam = "Engels in 24u", AantalDagen = 1 });
                context.SaveChanges();

                Console.WriteLine(jean.InstructeurNr);
                // zoeken op primary key
                Console.WriteLine(context.Instructeurs.Find(1).Familienaam);
            }
        }
    }
}
