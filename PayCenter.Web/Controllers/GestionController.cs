using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Security;
using System.Net;
using PayCenter.Seguridad.Filters;
using PayCenter.Web.Controllers.Base;


namespace PayCenter.Web.Controllers
{
    [RequiresAuthenticationAttribute]
    public class GestionController : BaseController
    {
        // GET: Gestion
      [RequiresAuthenticationAttribute]
        public ActionResult Index()
        {
            return View();
        }
    }
}