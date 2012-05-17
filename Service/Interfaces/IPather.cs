using System.Collections.Generic;
using Service.Models;

namespace Service.Interfaces
{
    public interface IPather
    {
        Path GeneratePath(IEnumerable<Layer> layers);
    }
}