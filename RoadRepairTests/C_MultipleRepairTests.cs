using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoadRepair;

namespace RoadRepairTests
{
    [TestClass]
    public class C_MultipleRepairTests
    {
        [TestMethod]
        public void ThreeRepairs()
        {
            var plan = new Planner();

            var road1 = new Road() { Length = 6, Width = 2, Potholes = 1 };
            var road2 = new Road() { Length = 3, Width = 2, Potholes = 5 };
            var road3 = new Road() { Length = 8, Width = 2, Potholes = 6 };

            var roads = new List<Road>(){ road1, road2, road3 };

            // TODO make the planner calculate the total cost of all the repairs for the list of roads.

            var cost = plan.GetCostOfRepairs(roads);
            Assert.AreEqual(226, cost, 0.00001);
        }

        [TestMethod]
        public void LimitedMoney()
        {
            var plan = new Planner();

            var road1 = new Road() { Length = 6, Width = 2, Potholes = 1 };
            var road2 = new Road() { Length = 3, Width = 2, Potholes = 5 };
            var road3 = new Road() { Length = 8, Width = 2, Potholes = 6 };
            
            var roads = new List<Road>() { road1, road2, road3 };

            // TODO make the planner work out which roads to repair, if there is not enough money available to repair all of them.
            // Try to make the planner select the roads that will fix the highest number of potholes.

            // So for this test, the total cost of the repairs to the selected roads must not exceed the available money.
            // Note that the available money (465) is less than the total cost (470) needed to fix all 3 roads in the previous test.
            var availableMoney = 220;

            var roadsRepaired = plan.SelectRoadsToRepair(roads, availableMoney);

            var potholesRepaired = 0;
            foreach (var road in roadsRepaired)
            {
                potholesRepaired += road.Potholes;
            }

            Assert.IsTrue(potholesRepaired >= 11);

            var cost = plan.GetCostOfRepairs(roadsRepaired);
            Assert.IsTrue(cost <= availableMoney);
        }

    }
}
