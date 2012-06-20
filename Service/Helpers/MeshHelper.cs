using System.Linq;
using Service.Interfaces;
using Service.Models;

namespace Service.Helpers
{
    public class MeshHelper : IMeshHelper
    {
        public void CenterMesh(Mesh mesh)
        {
            TranslateMesh(mesh, CalculateCenterVector(mesh));
        }

        public void PutMeshOnPlatform(Mesh mesh)
        {
            TranslateMesh(mesh, CalculatePutOnPlatformVector(mesh));
        }

        public void TranslateMesh(Mesh mesh, Point vector)
        {
            foreach (var vertex in mesh.Facets.SelectMany(facet => facet.Vertices))
            {
                vertex.X += vector.X;
                vertex.Y += vector.Y;
                vertex.Z += vector.Z;
            }
        }

        public bool IsMeshManifold(Mesh mesh)
        {
            return true;
        }

        public Point CalculateCenterVector(Mesh mesh)
        {
            float minX, minY, minZ, maxX, maxY, maxZ;
            CalculateBounds(mesh, out minX, out minY, out minZ, out maxX, out maxY, out maxZ);

            return new Point
                {
                    X = -((minX + maxX) / 2),
                    Y = -((minY + maxY) / 2),
                    Z = -minZ
                };
        }

        public Point CalculatePutOnPlatformVector(Mesh mesh)
        {
            float minX, minY, minZ, maxX, maxY, maxZ;
            CalculateBounds(mesh, out minX, out minY, out minZ, out maxX, out maxY, out maxZ);

            return new Point
            {
                X = 0,
                Y = 0,
                Z = -minZ
            };
        }

        public void CalculateBounds(Mesh mesh, out float minX, out float maxX, out float minY, out float maxY, out float minZ, out float maxZ)
        {
            minX = minY = minZ = float.MaxValue;
            maxX = maxY = maxZ = float.MinValue;

            foreach (var point in mesh.Facets.SelectMany(facet => facet.Vertices))
            {
                if (point.X < minX)
                {
                    minX = point.X;
                }

                if (point.Y < minY)
                {
                    minY = point.Y;
                }

                if (point.Z < minZ)
                {
                    minZ = point.Z;
                }

                if (point.X > maxX)
                {
                    maxX = point.X;
                }

                if (point.Y > maxY)
                {
                    maxY = point.Y;
                }

                if (point.Z > maxZ)
                {
                    maxZ = point.Z;
                }
            }
        }
    }
}
