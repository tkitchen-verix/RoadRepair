namespace RoadRepair.Repairs
{
    /// <summary>
    /// Filling is where you fix only the individual potholes.
    /// </summary>
    public class Filling
    {
        public Filling(Road road)
        {
            Potholes = road.Potholes;
            CostPerHole = 10;
        }

        public int Potholes { get; }

        public double CostPerHole { get; }

        public double GetCost()
        {
            var cost = Potholes * CostPerHole;
            return cost;
        }

        public override string ToString() => "Filling";
    }
}
