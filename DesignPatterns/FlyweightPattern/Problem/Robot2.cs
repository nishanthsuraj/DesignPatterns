namespace CodingInterviewSolutions.DesignPatterns.FlyweightPattern.Problem
{
    internal class Demo
    {
        private void Execute()
        {
            int x = 0, y = 100;
            // Creating int.MaxValue of Human Robots (Huge Memory consumption)
            for (int i = 0; i < int.MaxValue; i++, x++, y--)
            {
                Sprite2 sprite = new Sprite2();
                Robot2 robot = new Robot2(RobotType2.Human, sprite, x, y);
            }
        }
    }

    internal class Robot2
    {
        public RobotType2 RobotType { get; set; } // Extrensic Data
        public Sprite2 Sprite { get; set; } // Extrensic Data
        public int CoordinateX { get; set; } // Intrinsic Data
        public int CoordinateY { get; set; } // Intrinsic Data

        public Robot2(RobotType2 robotType, Sprite2 sprite, int coordinateX, int coordinateY)
        {
            RobotType = robotType;
            Sprite = sprite;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }

    internal enum RobotType2
    {
        Human,
        Dog
    }

    internal class Sprite2
    {
        // Implements 2D image rendering
    }
}
