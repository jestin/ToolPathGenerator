using Service.Interfaces;
using Service.Models;

namespace Service
{
    public class GCodeGenerator : IGCodeGenerator
    {
        public string GenerateGCode(Path path)
        {
            return "G1 0 0 0\n";
        }
    }
}
