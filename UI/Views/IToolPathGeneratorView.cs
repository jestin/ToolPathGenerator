using Framework.MVP;
using UI.Presenters;

namespace UI.Views
{
    public interface IToolPathGeneratorView : IView<IToolPathGeneratorPresenter>
    {
        string FileName { get; set; }
        string GCode { set; }
    }
}
