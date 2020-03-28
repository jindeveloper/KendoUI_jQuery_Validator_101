
using System.Web.Mvc;

namespace KendoUI_jQuery_Validator_101.Controllers
{
    public class jQueryKendoUIValidator_ExamplesController : Controller
    {
        // GET: jQueryKendoUIValidator_Examples
        public ActionResult Index()
        {
            return View("QuickBasicExample");
        }

        public ActionResult ChangeErrorTemplateAndOnBlurEvent()
        {
            return View();
        }

        public ActionResult ValidatioFormCompletes()
        {
            return View();
        }

        public ActionResult DefaultRules()
        {
            return View();
        }

        public ActionResult DefaultRulesWithCustomMessage()
        {
            return View();
        }

        public ActionResult CustomRulesWithCustomMessage()
        {
            return View();
        }

        public JsonResult CheckUserName(string username)
        {
            if(username == "jin888")
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return  Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}