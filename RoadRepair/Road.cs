namespace RoadRepair
{
    public class Road
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public int Potholes { get; set; }

        /// <summary>
        /// Calculates Pothole Density for the Road
        /// </summary>
        /// <returns></returns>
        public double GetPotholeDensity()
        {
            var potholeDensity = Potholes / (Width * Length);
            return potholeDensity;
        }
    }
}
