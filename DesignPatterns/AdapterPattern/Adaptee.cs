namespace CodingInterviewSolutions.DesignPatterns.AdapterPattern
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    internal class Adaptee
    {
        public virtual void Request()
        {
            Console.WriteLine("Specific Target Request()");
        }
    }
}
