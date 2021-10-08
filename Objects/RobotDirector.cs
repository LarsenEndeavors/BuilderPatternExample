namespace BuilderPatternExample.Objects
{
    public class RobotDirector
    {
        private RobotBuilder RobotBuilder { get; set; }

        public RobotDirector(RobotBuilder robotBuilder)
        {
            RobotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return RobotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            RobotBuilder.MakeRobot();
        }
        
    }
}