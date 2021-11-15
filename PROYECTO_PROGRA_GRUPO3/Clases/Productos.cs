using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PROGRA_GRUPO3.Models;

namespace PROYECTO_PROGRA_GRUPO3.Clases
{
    public class Productos
    {
        PROYECTO_PROGRAEntities db = new PROYECTO_PROGRAEntities();
        public IEnumerable<PRODUCTOS> Consultar()
        {
            return db.PRODUCTOS.ToList();
        }

        public void Guardar(PRODUCTOS modelo)
        {
            db.PRODUCTOS.Add(modelo);
            db.SaveChanges();
        }

        public void Modificar(PRODUCTOS modelo)
        {
            db.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Eliminar(PRODUCTOS modelo)
        {
            db.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public PRODUCTOS Consultar(int id)
        {
            return db.PRODUCTOS.FirstOrDefault(p => p.ID_PRODUCTO == id);
        }
    }
}