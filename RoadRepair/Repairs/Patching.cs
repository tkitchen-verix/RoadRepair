namespace RoadRepair.Repairs
{
    /// <summary>
    /// Patching is where you repair parts of the road, but not the whole road.
    /// </summary>
    public class Patching
    {
        public Patching(Road road)
        {
            Width = road.Width;
            Length = road.Length;
            Potholes = road.Potholes;
            UnitCost = 1;
        }

        public double Width { get; }
        public double Length { get; }
        public int Potholes { get; }
        public double UnitCost { get; }

        public double GetCost()
        {
            var cost = Potholes * Width * Length * UnitCost;
            return cost;
        }
        public override string ToString() => "Patching";
    }
}