using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoadRepair;
using RoadRepair.Repairs;

namespace RoadRepairTests
{
    [TestClass]
    public class B_PlannerTests
    {
        [TestMethod]
        public void CalculateTime()
        {
            var planner = new Planner();
            planner.HoursOfWork = 5;
            planner.Workers = 2;
            var time = planner.GetTime();
            Assert.AreEqual(2.5, time);
        }

        [TestMethod]
        public void PlanRepairForRoadWithFewPotholes()
        {
            var road = new Road { Length = 10, Width = 5 };
            road.Potholes = 2;

            var planner = new Planner();
            var repair = planner.SelectRepairType(road);
            Assert.IsTrue(repair is Filling, "The repair should be filling");
        }

        [TestMethod]
        public void PlanRepairForRoadWithSomePotholes()
        {
            var road = new Road {Length = 10, Width = 5};
            road.Potholes = 15;

            var planner = new Planner();
            var repair = planner.SelectRepairType(road);
            Assert.IsTrue(repair is Patching, "The repair should be patching");
        }

        [TestMethod]
        public void PlanRepairForRoadWithManyPotholes()
        {
            var road = new Road { Length = 10, Width = 5 };
            road.Potholes = 30;

            var planner = new Planner();
            var repair = planner.SelectRepairType(road);
            Assert.IsTrue(repair is Resurfacing, "The repair should be resurfacing");
        }


    }
}
