namespace CodingInterviewSolutions.DesignPatterns.FlyweightPattern.Solution
{
    // Flyweight 
    internal class Robot : IRobot
    {
        public RobotType RobotType { get; } // Extrensic Data
        public Sprite Sprite { get; } // Extrensic Data

        public Robot(RobotType robotType, Sprite sprite)
        {
            RobotType = robotType;
            Sprite = sprite;
        }


        public void Display(int coordinateX, int coordinateY)
        {
            Console.WriteLine($"{RobotType} is created at coordinates [{coordinateX},{coordinateY}]");
        }
    }
}
