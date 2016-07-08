using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface IManagment
    {
        void addOsoba(Osoba osoba);
        void removeOsoba(Osoba osoba);
        Osoba getPersonById(int id);
        Osoba[] getAllOsoba();
    }
}