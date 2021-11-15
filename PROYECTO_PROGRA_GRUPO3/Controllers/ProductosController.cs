using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROYECTO_PROGRA_GRUPO3.Models;
using PROYECTO_PROGRA_GRUPO3.Clases;

namespace PROYECTO_PROGRA_GRUPO3.Controllers
{
    public class ProductosController : Controller
    {
        Productos productos = new Productos();
        // GET: Productos
        public ActionResult Index()
        {
            IEnumerable<PRODUCTOS> lst = productos.Consultar();
            return View(lst);
        }

        public ActionResult Guardar(PRODUCTOS modelo)
        {
            ViewBag.Mensaje = "";
            return View(modelo);
        }

        public ActionResult Nuevo(PRODUCTOS modelo)
        {
            productos.Guardar(modelo);
            ViewBag.Mensaje = "El producto se guardó correctamente";
            return View("Guardar", modelo);
        }

        public ActionResult Detalle(int id)
        {
            PRODUCTOS modelo = productos.Consultar(id);
            return View(modelo);
        }

        public ActionResult Modificar(int id)
        {
            PRODUCTOS modelo = productos.Consultar(id);
            return View(modelo);
        }

        public ActionResult Cambiar(PRODUCTOS modelo)
        {
            productos.Modificar(modelo);
            ViewBag.Mensaje = "El producto se modificó correctamente";
            return View("Modificar", modelo);
        }

        public ActionResult Eliminar(int id)
        {
            PRODUCTOS modelo = new PRODUCTOS()
            {
                ID_PRODUCTO = id
            };
            productos.Eliminar(modelo);
            ViewBag.Mensaje = "El producto se eliminó correctamente";
            IEnumerable<PRODUCTOS> lst = productos.Consultar();
            return View("Index", lst);
        }
    }
}