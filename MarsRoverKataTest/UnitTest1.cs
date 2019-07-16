using NUnit.Framework;
using MarsRoverKata;
using RoverEngine;
using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework.Interfaces;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        [TestCase(5, 5, 0, 0, 'N', "RRRR", "0 0 N")]
        [TestCase(5, 5, 0, 0, 'N', "L", "0 0 W")]
        [TestCase(5, 5, 0, 0, 'N', "R", "0 0 E")]
        [TestCase(5, 5, 0, 0, 'W', "L", "0 0 S")]
        [TestCase(5, 5, 0, 0, 'W', "R", "0 0 N")]
        [TestCase(5, 5, 0, 0, 'S', "L", "0 0 E")]
        [TestCase(5, 5, 0, 0, 'S', "R", "0 0 W")]
        [TestCase(5, 5, 0, 0, 'E', "L", "0 0 N")]
        [TestCase(5, 5, 0, 0, 'E', "R", "0 0 S")]
        [TestCase(5, 5, 1, 1, 'N', "M", "1 2 N")]
        [TestCase(5, 5, 1, 1, 'W', "M", "0 1 W")]
        [TestCase(5, 5, 1, 1, 'S', "M", "1 0 S")]
        [TestCase(5, 5, 1, 1, 'E', "M", "2 1 E")]
        [TestCase(5, 5, 0, 0, 'N', "M", "0 1 N")]
        [TestCase(5, 5, 1, 1, 'N', "MLMR", "0 2 N")]
        [TestCase(5, 5, 1, 1, 'W', "MLMLMLM", "1 1 N")]
        [TestCase(5, 5, 0, 0, 'N', "MMMMM", "0 5 N")]
        [TestCase(5, 5, 0, 0, 'E', "MMMMM", "5 0 E")]
        [TestCase(5, 5, 0, 0, 'N', "RMLMRMLMRMLMRMLM", "4 4 N")]
        
        public void TestMoveRover(int pltx,int plty, int rvrx, int rvry, char hdg, string command, string expectedResult)
        {
            Plateau land = new Plateau(pltx, plty);
            Rover rover = new Rover(rvrx, rvry, hdg, land.Dimensions());
            rover.MoveRover(command);
            Assert.AreEqual(expectedResult, rover.ReturnPosition());
        }

        [TestCase( 5, 5, 0, 0, 'N')]
        public void TestDisplay(int pltx, int plty, int rvrx, int rvry, char hdg)
        {
            Plateau land = new Plateau(pltx, plty);
            Rover rover = new Rover(rvrx, rvry, hdg, land.Dimensions());
            using (var consoleOutput = new MarsRoverKataTest.ConsoleOutput())
            {
                rover.DisplayPosition();
                Assert.AreEqual("0 0 N\r\n", consoleOutput.GetOutput());
            }
        }

        [Test]
        public void TestProgram()
        {
        }


    }
}