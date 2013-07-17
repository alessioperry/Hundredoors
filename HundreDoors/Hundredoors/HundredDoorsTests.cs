using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Hundredoors
{
    [TestFixture]
    public class HundredDoorsTests
    {
        [Test]
        public void NunitWork()
        {
            Assert.True(true);
        }

        [Test]
        public void ManMakeFirstStep()
        {
            var man = new Man();
            var footage = new Footage(1);

            man.MakeStep(footage);

            Assert.AreEqual(footage.Length(), man.StepsCunt());
        }

        [Test]
        public void ManMakeTwoSteps()
        {
            var man = new Man();
            var footage = new Footage(1);

            man.MakeStep(footage);
            man.MakeStep(footage);

            Assert.AreEqual(2, man.StepsCunt());
        }

        [Test]
        public void ManMakeStepLongTwo()
        {
            var man = new Man();
            var footage = new Footage(2);

            man.MakeStep(footage);

            Assert.AreEqual(footage.Length(), man.StepsCunt());
        }

        [Test]
        public void ManMakeStepLongTree()
        {
            var man = new Man();
            var footage = new Footage(3);

            man.MakeStep(footage);

            Assert.AreEqual(footage.Length(), man.StepsCunt());
        }

        [Test]
        public void ToggleClosedDoor()
        {
            var door = new Door(Status.Closed);
            door.Toogle();
            Assert.AreEqual(Status.Open, door.GetSatus());
        }

        [Test]
        public void ToggleOpenedDoor()
        {
            var door = new Door(Status.Open);
            door.Toogle();
            Assert.AreEqual(Status.Closed, door.GetSatus());
        }

        [Test]
        public void HundredDoors()
        {
            var count = 100;

            var doors = new Tunnel(count);

            var man = new Man();

            for (var i = 1; i < count + 1; i++)
            {
                var footage = new Footage(i);

                for (var y = footage.Length(); y < count; y += footage.Length() + 1)
                {
                   man.MakeStep(footage);
                   doors.GetDoor(man.StepsCunt()).Toogle();
                }
            }

            
            var result = new StringBuilder();
            for (var i = 0; i < 100; i++)
               result.Append(string.Format("Door #{0} : {1}", i,doors.GetDoor(i).GetSatus()));

            Assert.AreEqual(Resolution(),result.ToString());
        }

        private static string Resolution()
        {
            // Initialize a vector of n boolean values
            var doors = new bool[30];

            // Process the doors
            for (var pass = 0; pass < 30; pass++)
                for (var current = pass; current < 30; current += pass +1)
                    doors[current] = !doors[current];

            var result = new StringBuilder();

            for (var i = 0; i < 100; i++)
                result.Append(string.Format("Door #{0} : {1}", i, doors[i] == true ? Status.Open : Status.Closed));

            return result.ToString();
        }
    }
}