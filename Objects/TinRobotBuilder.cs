using System;

namespace BuilderPatternExample.Objects
{
    public class TinRobotBuilder : RobotBuilder
    {
        
        private Robot Robot { get; set; }

        public TinRobotBuilder()
        {
            Robot = new Robot();
        }

        public void BuildRobotHead()
        {
            Robot.SetRobotHead("Tin head");
        }

        public void BuildRobotTorso()
        {
            Robot.SetRobotTorso("Tin Torso");
        }

        public void BuildRobotArms()
        {
            Robot.SetRobotArms("Tin Arms");
        }

        public void BuildRobotLegs()
        {
            Robot.SetRobotLegs("Tin Legs");
        }

        public Robot GetRobot()
        {
            return Robot;
        }

        public void MakeRobot()
        {
            BuildRobotHead();
            BuildRobotTorso();
            BuildRobotArms();
            BuildRobotLegs();
            Console.WriteLine("Robot built!");
        }
    }
}