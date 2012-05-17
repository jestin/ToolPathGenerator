using StructureMap.Configuration.DSL;
using UI.Presenters;

namespace UI
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IToolPathGeneratorPresenter>().Use<ToolPathGeneratorPresenter>();
        }
    }
}
