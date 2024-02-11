using CodingInterviewSolutions.DesignPatterns.ProxyPattern.Subject;

namespace CodingInterviewSolutions.DesignPatterns.ProxyPattern.Proxy
{
    internal class EmployeeProxyDAO : IEmployeeDAO
    {
        public EmployeeDAO EmployeeDAO { get; set; }

        public EmployeeProxyDAO()
        {
            EmployeeDAO = new EmployeeDAO();
        }

        public void Create(string name, string designation)
        {
            if (designation.ToUpper() != "ADMIN")
            {
                EmployeeDAO.Create(name, designation);
            }
            else
            {
                Console.WriteLine($"Only Non admins can be added to DB. So, Skipping {name}");
            }
        }

        public void Delete(string name)
        {
            EmployeeDAO.Delete(name);
        }
    }
}
