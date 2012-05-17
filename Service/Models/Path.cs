using System.Collections.Generic;

namespace Service.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Path
    {
        public IEnumerable<PathSegment> Segments { get; set; }
    }
}
