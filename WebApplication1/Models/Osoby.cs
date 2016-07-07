using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Osoby : IManagment
    {
        List<Osoba> lista = new List<Osoba>();
        public void addOsoba(Osoba osoba)
        {
            lista.Add(osoba);
        }

        public Osoba[] getAllOsoba()
        {
            return lista.ToArray();
        }

        public Osoba getPersonById(int id)
        {
            return lista.Single(k => k.id == id);
        }

        public void removeOsoba(Osoba osoba)
        {
            lista.Remove(osoba);
        }
    }
}