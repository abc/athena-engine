using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using AthenaEngine.Framework.Primatives;

namespace AthenaTest.Engine_Tests.Primatives_Testing
{
    [TestClass]
    public class BoundingBox2DTest
    {
        [TestMethod]
        public void Equality_WithSameRectangle_IsEqual()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = FirstBoundingBox2D;

            bool BoxesEqual = FirstBoundingBox2D.Equals(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesEqual, true);
        }

        [TestMethod]
        public void Equality_WithIdenticalRectangle_IsEqual()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);

            bool BoxesEqual = FirstBoundingBox2D.Equals(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesEqual, true);
        }

        [TestMethod]
        public void Equality_WithDifferentRectangle_IsNotEqual()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            Vector2 SecondBoundingBox2D_XY = new Vector2(32, 15);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(81, 542);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesEqual = FirstBoundingBox2D.Equals(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesEqual, false);
        }

        [TestMethod]
        public void Equality_WithItself_IsEqual()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);

            bool BoxesEqual = FirstBoundingBox2D.Equals(FirstBoundingBox2D);

            Assert.AreEqual<bool>(BoxesEqual, true);
        }

        [TestMethod]
        public void Collisions_WithItself_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(FirstBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }

        [TestMethod]
        public void Collisions_WithTotallyDifferentRectangle_IsNotTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            Vector2 SecondBoundingBox2D_XY = new Vector2(151, 214);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(81, 542);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, false);
        }

        [TestMethod]
        public void Collisions_WithEnvelopedRectangle_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(0, 0);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(100, 100);

            Vector2 SecondBoundingBox2D_XY = new Vector2(25, 25);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(25, 25);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }

        [TestMethod]
        public void Collisions_WithRectangleOnLeft_IsFalse()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(0, 10);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, false);
        }

        [TestMethod]
        public void Collisions_WithRectangleOnRight_IsFalse()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(20, 10);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, false);
        }

        [TestMethod]
        public void Collisions_WithRectangleOnTop_IsFalse()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(10, 0);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, false);
        }

        [TestMethod]
        public void Collisions_WithRectangleOnBottom_IsFalse()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(10, 20);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, false);
        }

        [TestMethod]
        public void Collisions_WithRectangleCollidingLeft_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(1, 10);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }

        [TestMethod]
        public void Collisions_WithRectangleCollidingRight_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(19, 10);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }

        [TestMethod]
        public void Collisions_WithRectangleCollidingTop_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(10, 1);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }

        [TestMethod]
        public void Collisions_WithRectangleCollidingBottom_IsTrue()
        {
            Vector2 FirstBoundingBox2D_XY = new Vector2(10, 10);
            Vector2 FirstBoundingBox2D_WidthHeight = new Vector2(10, 10);

            Vector2 SecondBoundingBox2D_XY = new Vector2(10, 19);
            Vector2 SecondBoundingBox2D_WidthHeight = new Vector2(10, 10);

            BoundingBox2D FirstBoundingBox2D = new BoundingBox2D(FirstBoundingBox2D_XY, FirstBoundingBox2D_WidthHeight);
            BoundingBox2D SecondBoundingBox2D = new BoundingBox2D(SecondBoundingBox2D_XY, SecondBoundingBox2D_WidthHeight);

            bool BoxesCollide = FirstBoundingBox2D.CollidesWith(SecondBoundingBox2D);

            Assert.AreEqual<bool>(BoxesCollide, true);
        }
    }
}
