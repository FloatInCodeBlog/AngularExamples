using System.Text;
using System.Web.Mvc;
using Westwind.Web.Mvc;

namespace RazorViewsForAngularJS.Controllers
{
    public class ViewsController : Controller
    {

        public ActionResult Get(string ctrl, string view)
        {
            var path = $"~/views/{ctrl}/{view}.cshtml";

            return Content(ViewRenderer.RenderPartialView(path), "text/html", Encoding.UTF8);
        }

    }
}