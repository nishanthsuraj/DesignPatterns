namespace CodingInterviewSolutions.DesignPatterns.PrototypePattern
{
    internal class Employee
    {
        //Value type Property
        public string Name { get; set; }
        //Value type Property
        public string Department { get; set; }
        //Reference type Property
        public Address EmpAddress { get; set; }
        //Creating a Cloned Object of the Current Object
        public Employee GetClone(bool isDeepCopy)
        {
            //Both Cloned and Existing Object Point to the Same Memory Location of the Address Object
            Employee emp = (Employee)this.MemberwiseClone();

            if (isDeepCopy)
            {
                emp.EmpAddress = emp.EmpAddress.GetClone();

            }
            return emp;

        }
    }
}
