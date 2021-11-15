using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PROGRA_GRUPO3.Models;

namespace PROYECTO_PROGRA_GRUPO3.Clases
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string APELLIDO1_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string CORREO_USUARIO { get; set; }
        public int CLAVE { get; set; }

        PROYECTO_PROGRAEntities db = new PROYECTO_PROGRAEntities();

        public bool Autententicar()
        {
            return db.USUARIOS.Where(u => u.USUARIO == this.USUARIO
            && u.CLAVE == this.CLAVE).FirstOrDefault() != null;

        }
    }
}