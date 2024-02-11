namespace CodingInterviewSolutions.DesignPatterns.FlyweightPattern.Solution
{
    internal class RobotFactory
    {
        private static readonly IDictionary<RobotType, IRobot> robots = new Dictionary<RobotType, IRobot>();

        public IRobot GetRobotFromType(RobotType robotType)
        {
            if (!robots.ContainsKey(robotType))
            {
                Sprite sprite = new Sprite();
                Robot robot = new Robot(robotType, sprite);
                robots.Add(robotType, robot);
            }

            return robots[robotType];
        }
    }
}
