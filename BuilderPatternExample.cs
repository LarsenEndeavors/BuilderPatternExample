using System;
using BuilderPatternExample.Objects;

namespace BuilderPatternExample
{
    internal static class BuilderPatternExample
    {
        private static void Main()
        {
            // This is the crux of the builder pattern, you create an object that implements an interface
            // with a blueprint filled out, then pass that to the director and have the director create the object
            
            var robotBuilder = new TinRobotBuilder();
            var robotDirector = new RobotDirector(robotBuilder);
            robotDirector.MakeRobot();

            var robot = robotDirector.GetRobot();

            Console.WriteLine(robot.GetRobotHead());
            Console.WriteLine(robot.GetRobotTorso());
            Console.WriteLine(robot.GetRobotArms());
            Console.WriteLine(robot.GetRobotLegs());
        }
    }
}