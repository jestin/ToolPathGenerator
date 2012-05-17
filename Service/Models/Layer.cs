using System.Collections.Generic;

namespace Service.Models
{
    /// <summary>
    /// A 2D vector representation of the layer.  This is a not the actual paths of the layer.
    /// </summary>
    public class Layer
    {
        /// <summary>
        /// The loops that define the edges of the layer
        /// </summary>
        IEnumerable<IEnumerable<Line>> Loops { get; set; }
    }
}
