using System;
using System.Drawing;
using NUnit.Framework;

namespace Manipulation
{
    public static class AnglesToCoordinatesTask
    {
        public static PointF[] GetJointPositions(double shoulder, double elbow, double wrist)
        {
            float positionX = Manipulator.UpperArm * (float)Math.Cos(shoulder);
            float positionY = Manipulator.UpperArm * (float)Math.Sin(shoulder);
            var elbowPos = new PointF(positionX, positionY);

            positionX += Manipulator.Forearm * (float)Math.Cos(elbow + shoulder - Math.PI);
            positionY += Manipulator.Forearm * (float)Math.Sin(elbow + shoulder - Math.PI);
            var wristPos = new PointF(positionX, positionY);

            positionX += Manipulator.Palm * (float)Math.Cos(wrist + elbow + shoulder - 2 * Math.PI);
            positionY += Manipulator.Palm * (float)Math.Sin(wrist + elbow + shoulder - 2 * Math.PI);
            var palmEndPos = new PointF(positionX, positionY);

            return new PointF[]
            {
                elbowPos,
                wristPos,
                palmEndPos
            };
        }
    }

    [TestFixture]
    public class AnglesToCoordinatesTask_Tests
    {
        [TestCase(Math.PI / 2, Math.PI / 2, Math.PI, Manipulator.Forearm + Manipulator.Palm, Manipulator.UpperArm)]
        public void TestGetJointPositions(double shoulder, double elbow, double wrist, double palmEndX, double palmEndY)
        {
            var joints = AnglesToCoordinatesTask.GetJointPositions(shoulder, elbow, wrist);
            Assert.AreEqual(palmEndX, joints[2].X, 1e-5, "palm endX");
            Assert.AreEqual(palmEndY, joints[2].Y, 1e-5, "palm endY");
        }
    }
}



