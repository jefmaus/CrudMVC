using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Services
{
    public class LoginService
    {
        private ModelDB db = new ModelDB();

        public Persona ValidarLogin(Persona persona)
        {
            Persona person = db.persona.FirstOrDefault(u => u.usuario == persona.usuario && u.clave == persona.clave && u.estado == "1");
            return person;
        }


    }
}