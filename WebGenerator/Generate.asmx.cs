using System;
using System.Web.Services;
using Framework.Injection;
using UI.Presenters;
using UI.Views;

namespace WebGenerator
{
    /// <summary>
    /// Summary description for Generate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Generate : WebService, IToolPathGeneratorView
    {
        public Generate()
        {
            Presenter = IoC.Resolve<IToolPathGeneratorPresenter>();
            Presenter.View = this;
            Presenter.InitView();
        }

        [WebMethod]
        public string GenerateGCode(string stlData)
        {
            Presenter.CreateGCodeFromStlData();

            return GCode;
        }

        public IToolPathGeneratorPresenter Presenter { get; set; }

        public string FileName { get; set; }
        public string StlData { get; set; }
        public string GCode { get; set; }
    }
}
