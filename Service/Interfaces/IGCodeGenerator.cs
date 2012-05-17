using Service.Models;

namespace Service.Interfaces
{
    public interface IGCodeGenerator
    {
        string GenerateGCode(Path path);
    }
}
