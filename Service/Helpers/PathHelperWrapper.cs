using Service.Interfaces;
using Service.Models;

namespace Service.Helpers
{
    public class PathHelperWrapper : IPathHelper
    {
        public Path AppendPaths(Path basePath, Path toAppend)
        {
            return PathHelper.AppendPaths(basePath, toAppend);
        }
    }
}
