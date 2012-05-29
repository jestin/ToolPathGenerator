using System.Web.Mvc;
using Framework.Injection;
using UI.Presenters;
using UI.Views;

namespace RestAPI.Controllers
{
    public class ToolPathController : Controller, IToolPathGeneratorView
    {

        public IToolPathGeneratorPresenter Presenter { get; set; }
        public string FileName { get; set; }
        public string StlData { get; set; }
        public string GCode { get; set; }

        public ToolPathController()
        {
            Presenter = IoC.Resolve<IToolPathGeneratorPresenter>();
            Presenter.View = this;
            Presenter.InitView();
        }

        //
        // GET: /ToolPath/Generate

        public ActionResult Generate(string stlData)
        {
            StlData = stlData;
            Presenter.CreateGCodeFromStlData();
            return Json(GCode, JsonRequestBehavior.AllowGet);
        }
    }
}
