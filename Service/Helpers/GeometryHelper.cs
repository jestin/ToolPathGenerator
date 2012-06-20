using Service.Interfaces;
using Service.Models;

namespace Service.Helpers
{
    /// <summary>
    /// This class performs many of the geometric operations that are needed for toolpath generation
    /// </summary>
    public class GeometryHelper : IGeometryHelper
    {
        public Layer IntersectMeshWithPlane(Mesh mesh, Point normalVector)
        {
            return new Layer();
        }
    }
}
