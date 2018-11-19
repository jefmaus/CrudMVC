using CrudMVC.Models;
using CrudMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            if(Session["usuario"] != null) { 
                return View();
            } else {
                return RedirectToAction("Login");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "Pagina de login";

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult ValidarLogin(Persona persona)
        {
            if (ModelState.IsValid) { 
                var loginService = new LoginService();
                var model = loginService.ValidarLogin(persona);
                if (model != null)
                {
                    Session["usuario"] = model.usuario.ToString();
                    Session["nombre"] = model.nombre;
                    Session["perfil"] = model.perfil.nombre;
                    return RedirectToAction("Index");
                } else {
                    ModelState.AddModelError("", "Verifique sus datos e intente de nuevo.");
                }
            }
            return View("Login");
        }

    }
}