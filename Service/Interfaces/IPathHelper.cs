using Service.Models;

namespace Service.Interfaces
{
    internal interface IPathHelper
    {
        Path AppendPaths(Path basePath, Path toAppend);
    }
}