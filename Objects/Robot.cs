namespace BuilderPatternExample.Objects
{
    public class Robot : RobotPlan
    {
        private string Head { get; set; }
        private string Torso { get; set; }
        private string Arms { get; set; }
        private string Legs { get; set; }

        public string GetRobotHead()
        {
            return Head;
        }
        
        public string GetRobotTorso()
        {
            return Torso;
        }
        
        public string GetRobotArms()
        {
            return Arms;
        }
        
        public string GetRobotLegs()
        {
            return Legs;
        }
        
        public void SetRobotHead(string head)
        {
            Head = head;
        }

        public void SetRobotTorso(string torso)
        {
            Torso = torso;
        }

        public void SetRobotArms(string arms)
        {
            Arms = arms;
        }

        public void SetRobotLegs(string legs)
        {
            Legs = legs;
        }
    }
}