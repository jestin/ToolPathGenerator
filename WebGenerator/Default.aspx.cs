using System;
using Framework.Injection;
using UI.Presenters;
using UI.Views;

namespace WebGenerator
{
    public partial class Default : System.Web.UI.Page, IToolPathGeneratorView
    {
        #region Constructors

        public Default()
        {
            Presenter = IoC.Resolve<IToolPathGeneratorPresenter>();
            Presenter.View = this;
            Presenter.InitView();
        }

        #endregion

        #region Properties

        public IToolPathGeneratorPresenter Presenter { get; set; }

        public string FileName {
            get
            {
                return StlTextBox.Text;
            }

            set
            {
                StlTextBox.Text = value;
            }
        }

        public string StlData
        {
            get { throw new NotImplementedException(); }
        }

        public string GCode
        {
            set
            {
                GCodeTextBox.Text = value;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            Presenter.CreateGCodeFromStlFile();
        }
    }
}
