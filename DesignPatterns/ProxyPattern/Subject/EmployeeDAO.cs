namespace CodingInterviewSolutions.DesignPatterns.ProxyPattern.Subject
{
    internal class EmployeeDAO : IEmployeeDAO
    {
        
        public void Create(string name, string designation)
        {
            Console.WriteLine($"Created Employee {name} - {designation}");
        }

        public void Delete(string name)
        {
            Console.WriteLine($"Deleted Employee {name}");
        }
    }
}
