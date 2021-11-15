using PROYECTO_PROGRA_GRUPO3.Clases;
using PROYECTO_PROGRA_GRUPO3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PROYECTO_PROGRA_GRUPO3.Controllers
{
    public class IngresarController : Controller
    {
        // GET: Ingresar
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario, string url)
        {
            if (IsValid(usuario))
            {
                /* Si el usuario es valido se genera un Cookie  con FALSE para que no persista */
                FormsAuthentication.SetAuthCookie(usuario.USUARIO, false);
                if (url != null)
                {
                    /* Si el usuario es valido y si la URL es diferente de nulo */
                    return Redirect(url);
                }
                /* Si no se va al home de la aplicación */
                return RedirectToAction("Index", "Home");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas.";
            return View(usuario);
        }

        public bool IsValid(Usuario usuario)
        {
            return usuario.Autententicar();
        }
        public ActionResult LogOut(USUARIOS usuario, string url)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}