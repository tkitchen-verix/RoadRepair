namespace RoadRepair.Repairs
{
    public class Resurfacing
    {
        public Resurfacing(Road road)
        {
            Width = road.Width;
            Length = road.Length;
            UnitCost = 20;
        }

        public double Width { get; }
        public double Length { get; }
        public double UnitCost { get; }

        public double GetCost()
        {
            var cost = Width * Length * UnitCost;
            return cost;
        }
        public override string ToString() => "Resurfacing";
    }
}
