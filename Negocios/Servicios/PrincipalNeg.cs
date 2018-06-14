using System;
using System.Collections.Generic;
using System.Text;
using Base.Interfaz;
using Base.ServicioInterfaz;
using Datos.Contexto;
namespace Negocios.Servicios
{
    public class PrincipalNeg
    {
        public  IPrincipal getPrincipalService()
        {
            return new PrincipalServicio(new PrincipalContexto());
        }
    }
}
