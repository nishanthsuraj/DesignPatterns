namespace CodingInterviewSolutions.DesignPatterns.VisitorPattern.Solution
{
    internal class MaintanenceVisitor : IRoomVisitor
    {
        public void Visit(IRoom roomElement)
        {
            if (roomElement.GetType() == typeof(ClassicRoom))
                Console.WriteLine("Maintainence of ClassicRoom.");
            else if (roomElement.GetType() == typeof(DeluxRoom))
                Console.WriteLine("Maintainence of DeluxRoom.");
        }
    }
}
