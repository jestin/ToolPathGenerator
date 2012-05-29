using System.Web.Mvc;
using UI.Presenters;

namespace RestAPI.Controllers
{
    public class ToolPathController : Controller
    {
        private readonly IToolPathGeneratorPresenter _presenter;

        public ToolPathController(IToolPathGeneratorPresenter presenter)
        {
            _presenter = presenter;
        }

        //
        // GET: /ToolPath/Generate

        public ActionResult Generate(string stlData)
        {
            return Json("");
        }

    }
}
