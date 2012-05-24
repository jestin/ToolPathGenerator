using Service.Interfaces;
using Service.Models;

namespace Service.Helpers
{
    public class MeshHelper : IMeshHelper
    {
        public Mesh CenterMesh(Mesh mesh)
        {
            return new Mesh();
        }

        public Mesh PutMeshOnPlatform(Mesh mesh)
        {
            return new Mesh();
        }

        public bool IsMeshManifold(Mesh mesh)
        {
            return true;
        }

        public Point CalculateCenterVector(Mesh mesh)
        {
            return new Point();
        }

        public Point CalculatePutOnPlatformVector(Mesh mesh)
        {
            return new Point();
        }

        public void CalculateBounds(Mesh mesh, out double minX, out double maxX, out double minY, out double maxY, out double minZ, out double maxZ)
        {
            minX = maxX = minY = maxY = minZ = maxZ = 0;
        }
    }
}
