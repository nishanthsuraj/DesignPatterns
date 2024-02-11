namespace CodingInterviewSolutions.DesignPatterns.AdapterPattern
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    internal class Adapter : Target
    {
        Adaptee Adaptee { get; set; }

        public Adapter(Adaptee adaptee)
        {
            Adaptee = adaptee;
        }

        public override void Request()
        {
            Adaptee.Request();
        }
    }
}
