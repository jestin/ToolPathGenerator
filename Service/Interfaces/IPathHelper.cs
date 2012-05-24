using Service.Models;

namespace Service.Interfaces
{
    public interface IPathHelper
    {
        Path AppendPaths(Path basePath, Path toAppend);
    }
}