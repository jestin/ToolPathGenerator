using Service.Models;

namespace Service.Interfaces
{
    public interface IMeshHelper
    {
        Mesh CenterMesh(Mesh mesh);
        Mesh PutMeshOnPlatform(Mesh mesh);
        bool IsMeshManifold(Mesh mesh);
        void CalculateBounds(Mesh mesh, out double minX, out double maxX, out double minY, out double maxY, out double minZ, out double maxZ);
    }
}