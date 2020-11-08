using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Principal;
using aernauticaimperialis;
using NUnit.Framework;
using Point = aernauticaimperialis.Point;

namespace aernauticaImperialis.unitTest {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void IsPointLegalTest() {
            Point p1 = new Point(14, 14, 4);
            Point p2 = new Point(-3, 15, 5);
            Point p3 = new Point(16, 15, 5);
            
            Map map = new Map();
            Assert.IsTrue(map.IsPointLegal(p1));
            Assert.IsFalse(map.IsPointLegal(p2));
            Assert.IsFalse(map.IsPointLegal(p3));
        }

        [Test]
        public void LoggerTest() {
            string message = "Servüs Leudis";

            Logger.GetInstance().Info(message);
            Assert.AreEqual("Servüs Leudis", message);
        }

        [Test]
        public void EqualsTest() {
            Point p1 = new Point(3, 3, 3);
            Point p2 = new Point(3, 3, 3);
            Point p3 = new Point(4, 3, 3);

            Assert.IsTrue(p1.Equals(p2));
            Assert.IsFalse(p1.Equals(p3));
        }

        [Test]
        public void IsPointFreeTest() {
            Map map = new Map();
            Point p = new Point(2,2,2);
            Aircraft aircraft = AircraftFactory.CreateHellion(new Point(2, 2, 2), 1);
            Assert.IsFalse(map.IsPointLegal(aircraft.Position));
        }

        [Test]
        public void CalculateMovementCostTest() {
            Map map = new Map();
            Aircraft aircraft = AircraftFactory.CreateBigBurna(new Point(2, 2, 2), 3);
            List<Point> route = aircraft.CalculateRoute(new Point(3, 4, 2));
            MovementCost costs = aircraft.CalculateMoveCost(route);
            Assert.AreEqual(2, costs.FieldCount);
            Assert.AreEqual(1, costs.ManeuverCost);
            Assert.AreEqual(2, costs.SpeedCost);
        }

        [Test]
        public void CalculateRouteTest() {
            Point p = new Point(1, 1, 1);
            List<Point> points = p.CalculateRoute(new Point(3, 3, 2));
            
            Assert.AreEqual(2, points.Count);
        }

        [Test]
        public void MoveTest() {
            Map map = new Map();
            Aircraft bigBurna = AircraftFactory.CreateBigBurna(new Point(1, 1, 1), 3);
            
            DefaultMoveBehaviour moveBehaviour = new DefaultMoveBehaviour();
            moveBehaviour.Move(bigBurna, new Point(2, 2, 1));
            Point p = new Point(2, 2, 1);
            Assert.AreEqual(p.X,bigBurna.Position.X);
            Assert.AreEqual(p.Y, bigBurna.Position.Y);
            Assert.AreEqual(p.Z, bigBurna.Position.Z);
        }

        [Test]
        public void IsSpinTest() {
            Aircraft aircraft = AircraftFactory.CreateBigBurna(new Point(1, 1, 1), 3);
            
            Assert.IsTrue(SpinBehaviour.IsSpin(aircraft));
        }

        [Test]
        public void HandlingTestTest() {
            
        }
        
    }
}