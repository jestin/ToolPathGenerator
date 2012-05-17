namespace Framework.MVP
{
    public interface IView<TPresenter>
    {
        TPresenter Presenter { get; set; }
    }
}
