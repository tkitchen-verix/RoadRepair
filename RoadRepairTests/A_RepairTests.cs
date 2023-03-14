using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoadRepair;
using RoadRepair.Repairs;

namespace RoadRepairTests
{
    [TestClass]
    public class A_RepairTests
    {
        [TestMethod]
        public void CalculateFillingCost()
        {
            var road = new Road { Length = 3, Width = 1.5, Potholes = 4};
            var repair = new Filling(road);
            var cost = repair.GetCost();
            Assert.AreEqual(40, cost);
        }
        
        [TestMethod]
        public void CalculatePatchingCost()
        {
            var road = new Road { Length = 3, Width = 1.5, Potholes = 4 };
            var repair = new Patching(road);
            var cost = repair.GetCost();
            Assert.AreEqual(18, cost);
        }

        [TestMethod]
        public void CalculateResurfacingCost()
        {
            var road = new Road { Length = 3, Width = 1.5, Potholes = 4 };
            var repair = new Resurfacing(road);
            var cost = repair.GetCost();
            Assert.AreEqual(90, cost);
        }

    }
}
