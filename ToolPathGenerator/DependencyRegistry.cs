using StructureMap.Configuration.DSL;
using ToolPathGenerator.Views;
using UI.Views;

namespace ToolPathGenerator
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IToolPathGeneratorView>().Use<ToolPathGeneratorConsoleView>();
        }
    }
}
