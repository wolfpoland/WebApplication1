using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestpwyController : ApiController
    {
        private readonly IManagment lista;
        public TestpwyController(IManagment lista)
        {
            this.lista = lista;
        }
        public TestpwyController()
        {
            lista = new Osoby();
        }
        public void PostOsoba(Osoba osoba)
        {
            lista.addOsoba(osoba);

        }
        public void DeleteOsoba(Osoba osoba)
        {
            lista.removeOsoba(osoba);
        }
        [HttpGet]
        public Osoba[] dawajWszystko()
        {
            return lista.getAllOsoba();
        }
        public Osoba dajOsobePoID(int id)
        {
            return lista.getPersonById(id);
        }
    }
}
