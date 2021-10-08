using System;
using BuilderPatternExample.Objects;

namespace BuilderPatternExample
{
    internal static class BuilderPatternExample
    {
        /*
        * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
        * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
        * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
        * I'm happy that you're here and here's proof that I have at least heard of this particular
        * pattern!
        *
        * Author: Nicholas Larsen
        * Date: 2021/10/07
        */
        
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