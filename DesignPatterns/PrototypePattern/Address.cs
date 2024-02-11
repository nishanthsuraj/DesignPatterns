namespace CodingInterviewSolutions.DesignPatterns.PrototypePattern
{
    internal class Address
    {
        public string address { get; set; }

        //Creating a Cloned Object of the Current Object
        public Address GetClone()
        {
            //Both Cloned and Existing Object Point to the Same Memory Location of the Address Object
            return (Address)this.MemberwiseClone();
        }
    }
}
