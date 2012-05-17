namespace Service.Models
{
    public class PathSegment
    {
        public Line Segment { get; set; }
        public int Speed { get; set; }

        public int ExtrusionSpeed { get; set; }
        public double ExtrusionVolume { get; set; }
    }
}
