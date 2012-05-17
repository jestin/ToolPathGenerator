using System;

namespace Framework.MVP
{
    public abstract class BasePresenter<TView, TPresenter> : IPresenter<TView, TPresenter> where TView : class, IView<TPresenter> where TPresenter : class, IPresenter<TView, TPresenter>
    {
// ReSharper disable InconsistentNaming
        protected TView _view;
// ReSharper restore InconsistentNaming

        public TView View
        {
            get { return _view; }
            set
            {
                _view = value;
                _view.Presenter = this as TPresenter;
            }
        }

        public virtual void InitView()
        {
            if (_view == null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
