namespace CodingInterviewSolutions.DesignPatterns.ProxyPattern.Subject
{
    internal interface IEmployeeDAO
    {
        void Create(string name, string designation);
        void Delete(string name);
    }
}
