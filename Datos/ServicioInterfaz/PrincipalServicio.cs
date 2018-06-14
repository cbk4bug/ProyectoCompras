using System;
using System.Collections.Generic;
using System.Text;
using Base.Interfaz;
using Base.Entity.Principal;
namespace Base.ServicioInterfaz
{
    public class PrincipalServicio : IPrincipal
    {
        private IPrincipal IPrincipal { get; set; }
        public PrincipalServicio(IPrincipal IPrincipal)
        {
            this.IPrincipal = IPrincipal;
        }
        //metodos
        public object AltaPreregistro(tblP_preregistro objPreregistro)
        {
           return IPrincipal.AltaPreregistro(objPreregistro);
        }
    }
}
