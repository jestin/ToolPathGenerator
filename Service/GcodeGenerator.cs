using Service.Interfaces;
using Service.Models;

namespace Service
{
    public class GCodeGenerator : IGCodeGenerator
    {
        public string GenerateGCode(Path path)
        {
            return "G1 X0 Y0 Z0";
        }
    }
}
