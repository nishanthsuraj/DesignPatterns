namespace CodingInterviewSolutions.DesignPatterns.VisitorPattern.Solution
{
    internal interface IRoom
    {
        public double RoomPrice { get; set; }
        public void Accept(IRoomVisitor roomVisitor);
    }
}
