namespace BuilderPatternExample.Objects
{
    public interface RobotPlan
    {
        public void SetRobotHead(string head);
        public void SetRobotTorso(string torso);
        public void SetRobotArms(string arms);
        public void SetRobotLegs(string legs);
    }
}