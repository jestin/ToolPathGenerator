namespace Framework.MVP
{
    public interface IPresenter<TView, TPresenter> where TView : IView<TPresenter> where TPresenter : IPresenter<TView, TPresenter>
    {
        TView View { get; set; }
        void InitView();
    }
}
