namespace CodingInterviewSolutions.DesignPatterns.VisitorPattern.Solution
{
    internal class RoomPriceVisitor : IRoomVisitor
    {
        public void Visit(IRoom roomElement)
        {
            if(roomElement.GetType() == typeof(ClassicRoom))
                roomElement.RoomPrice = 1000;
            else if (roomElement.GetType() == typeof(DeluxRoom))
                roomElement.RoomPrice = 2000;

        }
    }
}
