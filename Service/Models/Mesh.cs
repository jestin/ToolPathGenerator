using System.Collections.Generic;

namespace Service.Models
{
    public class Mesh
    {
        public ICollection<Point> Points;
        public ICollection<Line> HalfEdges;
        public ICollection<IEnumerable<Line>> Facets;
    }
}
