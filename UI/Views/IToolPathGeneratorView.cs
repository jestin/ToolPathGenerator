using Framework.MVP;
using UI.Presenters;

namespace UI.Views
{
    public interface IToolPathGeneratorView : IView<IToolPathGeneratorPresenter>
    {
        string FileName { get; set; }
        string StlData { get; }
        string GCode { set; }
    }
}
