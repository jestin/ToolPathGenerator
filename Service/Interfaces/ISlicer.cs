using System.Collections.Generic;
using Service.Models;

namespace Service.Interfaces
{
    public interface ISlicer
    {
        IEnumerable<Layer> Slice(Mesh mesh);
    }
}