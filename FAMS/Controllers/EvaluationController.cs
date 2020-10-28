using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAMS.Controllers
{
    public class EvaluationController : Controller
    {
        // GET: Evaluation
        public ActionResult InitialEval()
        {
            return View();
        }
    }
}