using System;
using System.Collections.Generic;
using System.Text;
using Base.Entity.Principal;//tablas modelo
using Base.Interfaz;

namespace Datos.Contexto
{
    public class PrincipalContexto: IPrincipal
    {
        public object AltaPreregistro(tblP_preregistro objPreregistro)
        {
             object obj = new object();
            obj = "Hola péps";
            return obj;
        }
    }
}
