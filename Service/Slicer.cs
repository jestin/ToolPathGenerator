using System.Collections.Generic;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    public class Slicer : ISlicer
    {
        public IEnumerable<Layer> Slice(Mesh mesh)
        {
            return new List<Layer>();
        }
    }
}
