namespace CodingInterviewSolutions.DesignPatterns.VisitorPattern.Solution
{
    internal class DeluxRoom : IRoom
    {
        public double RoomPrice { get; set; }

        public void Accept(IRoomVisitor roomVisitor)
        {
            roomVisitor.Visit(this);
        }
    }
}
