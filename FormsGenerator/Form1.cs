using System;
using System.Windows.Forms;
using Framework.Injection;
using UI.Presenters;
using UI.Views;

namespace FormsGenerator
{
    public partial class Form1 : Form, IToolPathGeneratorView
    {
        #region Properties

        public IToolPathGeneratorPresenter Presenter { get; set; }

        public string FileName
        {
            get { return StlTextBox.Text; }
            set { StlTextBox.Text = value; }
        }

        public string GCode
        {
            set { gCodeTextBox.Text = value; }
        }

        #endregion

        public Form1()
        {
            Presenter = IoC.Resolve<IToolPathGeneratorPresenter>();
            Presenter.View = this;
            Presenter.InitView();

            InitializeComponent();
        }

        private void GenerateGCode_button_Click(object sender, EventArgs e)
        {
            Presenter.CreateGCodeFromModel();
        }
    }
}
