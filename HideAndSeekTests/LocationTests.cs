using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HideAndSeekTests
{
    using System;
    using HideAndSeek;
    using System.Collections.Generic;    
    using System.Diagnostics;
    [TestClass]
    public class LocationTests
    {
        private Location center;

        /// <summary>
        /// Initializes each unit test by setting creating a new the center location
        /// and adding a room in each direction before the test
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            center = new Location("Hallway");
            center.Exits.Add(Direction.Northwest, new Location("Kitchen"));            
            center.Exits.Add(Direction.North, new Location("Bathroom"));
            center.Exits.Add(Direction.South, new Location("Living Room"));
            center.Exits.Add(Direction.West, new Location("Entry"));
            center.Exits.Add(Direction.Up, new Location("Landing"));
        }

        /// <summary>
        /// Make sure GetExit returns the location in a direction only if it exists
        /// </summary>
        [TestMethod]
        public void TestGetExit()
        {
            foreach (var l in center.Exits) Console.WriteLine(l.Value);
            var room = center.GetExit(Direction.Northwest);
            Console.WriteLine(room.Name);
            Console.WriteLine(center.Name);
        }

        /// <summary>
        /// Validates that the exit lists are working
        /// </summary>
        [TestMethod]
        public void TestExitList()
        {
            // This test will make sure the ExitList property works
        }

        /// <summary>
        /// Validates that each room’s name and return exit is created correctly
        /// </summary>
        [TestMethod]
        public void TestReturnExits()
        {
            // This test will test navigating through the center Location
        }

        /// <summary>
        /// Add a hall to one of the rooms and make sure the hall room’s names
        /// and return exits are created correctly
        /// </summary>
        [TestMethod]
        public void TestAddHall()
        {
            // This test will add a hallway with two locations and make sure they work
        }
    }
}
