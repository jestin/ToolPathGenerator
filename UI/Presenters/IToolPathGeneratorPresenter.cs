using Framework.MVP;
using UI.Views;

namespace UI.Presenters
{
    public interface IToolPathGeneratorPresenter : IPresenter<IToolPathGeneratorView, IToolPathGeneratorPresenter>
    {
        void CreateGCodeFromStlFile();
        void CreateGCodeFromStlData();
    }
}
