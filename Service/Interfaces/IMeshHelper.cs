using Service.Models;

namespace Service.Interfaces
{
    public interface IMeshHelper
    {
        void CenterMesh(Mesh mesh);
        void PutMeshOnPlatform(Mesh mesh);
        void TranslateMesh(Mesh mesh, Point vector);
        bool IsMeshManifold(Mesh mesh);
        void CalculateBounds(Mesh mesh, out float minX, out float maxX, out float minY, out float maxY, out float minZ, out float maxZ);
    }
}