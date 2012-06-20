using System.Collections.Generic;
using System.Collections.ObjectModel;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// This class is for slicing meshes into 2D layers
    /// </summary>
    public class Slicer : ISlicer
    {
        private readonly IMeshHelper _meshHelper;
        private readonly IGeometryHelper _geometryHelper;

        public Slicer(
            IMeshHelper meshHelper,
            IGeometryHelper geometryHelper)
        {
            _meshHelper = meshHelper;
            _geometryHelper = geometryHelper;
        }

        public IEnumerable<Layer> Slice(Mesh mesh)
        {
            const float layerHeight = (float) 0.3;
            float xMin, xMax, yMin, yMax, zMin, zMax;
            _meshHelper.CalculateBounds(mesh, out xMin, out xMax, out yMin, out yMax, out zMin, out zMax);

            var layers = new Collection<Layer>();

            for (float zHeight = (float) 0.0; zHeight < zMax; zHeight += layerHeight)
            {
                layers.Add(_geometryHelper.IntersectMeshWithPlane(mesh, new Point
                {
                    X = 0,
                    Y = 0,
                    Z = zHeight
                }));
            }

            return layers;
        }
    }
}
