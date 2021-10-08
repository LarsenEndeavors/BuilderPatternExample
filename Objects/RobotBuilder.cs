namespace BuilderPatternExample.Objects
{
    public interface RobotBuilder
    {
        public void BuildRobotHead();
        public void BuildRobotTorso();
        public void BuildRobotArms();
        public void BuildRobotLegs();
        public Robot GetRobot();
        public void MakeRobot();
    }
}