using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yurii_Bel_IT31.Controllers
{
    public class ВидыСетиController : Controller
    {
        //
        // GET: /ВидыСети/
        private ТеплосетиEntities db = new ТеплосетиEntities();
        public ActionResult ВидыСетиIndex()
        {
            var ВидСети = from m in db.ВидСети
                          select m;
            return View(ВидСети.ToList());
        }

    }
}
