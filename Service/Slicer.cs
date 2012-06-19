using System.Collections.Generic;
using System.Collections.ObjectModel;
using Service.Interfaces;
using Service.Models;

namespace Service
{
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
            const double layerHeight = 0.3;
            double xMin, xMax, yMin, yMax, zMin, zMax;
            _meshHelper.CalculateBounds(mesh, out xMin, out xMax, out yMin, out yMax, out zMin, out zMax);

            var layers = new Collection<Layer>();

            for (double zHeight = 0.0; zHeight < zMax; zHeight += layerHeight)
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
