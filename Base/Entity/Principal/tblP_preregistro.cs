using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Entity.Principal
{
    public class tblP_preregistro
    {
        public int id { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
    };
}
