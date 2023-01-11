using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Robot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RobotHead()
        {
            var head = new Head();
            var face = new Face();

            var ears = new List<Ear>();
            var hair = new Hair();
            var neck = new Neck();
            head.Ears = ears;
            head.Hair = hair;
            head.Neck = neck;
            head.Face = face;
            Assert.IsTrue(head.HasFace());
            Assert.IsTrue(head.HasHair());
            Assert.IsTrue(head.HasEars());
            Assert.IsTrue(head.HasNeck());

            var mouth = new Mouth();
            var eyes = new List<Eye>();
            var leftEye = new Eye();
            var rightEye = new Eye();
            eyes.Add(leftEye);
            eyes.Add(rightEye);
            face.Mouth = mouth;
            face.Eyes = eyes;
            Assert.IsTrue(face.HasMouth());
            Assert.IsTrue(face.HasEyes());
        }

        [TestMethod]
        public void OpenEyes()
        {

            //var leftEye = new Eye();
            //var rightEye = new Eye();
            var face = new Face();
            string side = "left";
            //face.AddEye(leftEye);
            //face.AddEye(rightEye);
            face.OpenEye(side);
            var _leftEye = face.GetEye();
            Assert.AreEqual(_leftEye.Height, 100);
            Assert.AreEqual(_leftEye.Width, 100);
            Assert.AreEqual(_leftEye.Color, "Red");
        }
        public void RobotLeg()
        {

        }

        [TestMethod]
        public void Testtemp()
        {
            var person = new Person();
        }

        [TestMethod]
        public void TestKickLeg()
        {
            var robot = new IRobot();
            foreach(var k in robot.Legs) 
            {
                k.KickLeg("left", 0, 10);
                Assert.AreEqual(k.HadKicked("left", 0, 10), true);
                k.SetLegLocation();
                Assert.AreEqual(k.rutchanve(), true);
            }
        }   
    }

}
