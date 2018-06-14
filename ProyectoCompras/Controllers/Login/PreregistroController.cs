using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Base.Entity.Principal;
using Negocios.Servicios;
//using Datos.Contexto;
namespace ProyectoCompras.Controllers.Login
{
    public class PreregistroController : Controller
    {
        //herencia de clases
         PrincipalNeg principalNeg = new PrincipalNeg();//negocios instancia
        



        // GET: Preregistro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AltaPreregistro(tblP_preregistro objPreregistro)
        {
            var result = new Dictionary<string, object>();
            try
            {
                //roberto prueba ds
               principalNeg.getPrincipalService().AltaPreregistro(objPreregistro);
               result.Add("ValorGuardado", principalNeg.getPrincipalService().AltaPreregistro(objPreregistro));
            }
            catch
            {
                
            }
            return Json(result);
        }
    }
}