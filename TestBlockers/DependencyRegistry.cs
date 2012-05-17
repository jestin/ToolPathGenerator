using StructureMap.Configuration.DSL;
using TestBlockers.Views;
using UI.Views;

namespace TestBlockers
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IToolPathGeneratorView>().Use<ToolPathGeneratorConsoleView>();
        }
    }
}
