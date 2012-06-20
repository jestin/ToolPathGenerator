using System.Linq;
using Service.Interfaces;
using Service.Models;

namespace Service.Helpers
{
    /// <summary>
    /// This class performs operations and calculations on Meshes
    /// </summary>
    public class MeshHelper : IMeshHelper
    {
        /// <summary>
        /// Centers a Mesh around the origin in XY and places it on the platform in Z
        /// </summary>
        /// <param name="mesh"></param>
        public void CenterMesh(Mesh mesh)
        {
            TranslateMesh(mesh, CalculateCenterVector(mesh));
        }

        /// <summary>
        /// Places a Mesh on the build platform
        /// </summary>
        /// <param name="mesh"></param>
        public void PutMeshOnPlatform(Mesh mesh)
        {
            TranslateMesh(mesh, CalculatePutOnPlatformVector(mesh));
        }

        /// <summary>
        /// Moves a Mesh in XYZ space
        /// </summary>
        /// <param name="mesh"></param>
        /// <param name="vector"></param>
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

            // TODO:  Figure out if we can do this simpler with LINQ, and change it to use floating-point-safe operations

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
