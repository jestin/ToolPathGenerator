using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// This class is for taking a non-coded path and encoding it into GCode
    /// </summary>
    public class GCodeGenerator : IGCodeGenerator
    {
        public string GenerateGCode(Path path)
        {
            return "G1 X0 Y0 Z0";
        }
    }
}
