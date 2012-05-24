using Framework.Injection;
using UI.Presenters;
using UI.Views;

namespace TestBlockers
{
    public class Program
    {
        #region Properties

        public static IToolPathGeneratorPresenter Presenter { get; set; }

        #endregion

        static void Main(string[] args)
        {
            StructureMap.ObjectFactory.Initialize(x =>
                                                      {
                                                          x.AddRegistry(new DependencyRegistry());
                                                          x.AddRegistry(new UI.DependencyRegistry());
                                                          x.AddRegistry(new Service.DependencyRegistry());
                                                      });

            Presenter = IoC.Resolve<IToolPathGeneratorPresenter>();
            Presenter.View = IoC.Resolve<IToolPathGeneratorView>();

            Presenter.View.FileName = args.Length > 0 ? args[0] : null;
            Presenter.CreateGCodeFromStlFile();
        }
    }
}
