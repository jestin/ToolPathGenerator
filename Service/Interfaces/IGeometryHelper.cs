using Service.Models;

namespace Service.Interfaces
{
    public interface IGeometryHelper
    {
        Layer IntersectMeshWithPlane(Mesh mesh, Point normalVector);
    }
}
