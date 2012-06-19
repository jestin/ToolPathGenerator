using System.Collections.Generic;

namespace Service.Models
{
    public class Facet
    {
        public Point Normal { get; set; }
        public ICollection<Point> Vertices { get; set; }
    }
}
