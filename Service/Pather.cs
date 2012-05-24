using System.Collections.Generic;
using System.Linq;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    public class Pather : IPather
    {
        private readonly IPathHelper _pathHelper;

        public Pather(IPathHelper pathHelper)
        {
            _pathHelper = pathHelper;
        }

        public Path GeneratePath(IEnumerable<Layer> layers)
        {
            var complete = new Path();

            // set from configuration
            var lookBehind = 2;
            var lookAhead = 2;

            for(var current = 0; current < layers.Count(); current++)
            {
                var layer = layers.ElementAt(current);

                var prevLayers = new List<Layer>();
                var nextLayers = new List<Layer>();

                for (var offset = 1; offset <= lookBehind; offset++)
                {
                    var prev = current - offset;
                    if (prev >= 0)
                    {
                        prevLayers.Add(layers.ElementAt(prev));
                    }
                }

                for (var offset = 1; offset <= lookAhead; offset++)
                {
                    var next = current + offset;
                    if (next < layers.Count())
                    {
                        prevLayers.Add(layers.ElementAt(next));
                    }
                }

                complete = _pathHelper.AppendPaths(complete, GeneratePathForLayer(layer, prevLayers, nextLayers));
            }

            return complete;
        }

        /// <summary>
        /// Generates the path for a single layer.  The prevLayers and nextLayers parameters will contain as many layers as needed for the current to generate correctly.
        /// </summary>
        /// <param name="layer">The layer to be pathed</param>
        /// <param name="prevLayers">A lookbehind of the previous layers that have already been pathed</param>
        /// <param name="nextLayers">A lookahead of the next layers to be pathed</param>
        /// <returns></returns>
        private Path GeneratePathForLayer(Layer layer, IEnumerable<Layer> prevLayers, IEnumerable<Layer> nextLayers)
        {
            return new Path();
        }
    }
}
