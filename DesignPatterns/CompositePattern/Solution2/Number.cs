namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution2
{
    internal class Number : IArithmeticExpression
    {
        public int Value { get; set; }
        public Number(int value)
        {
            Value = value;
        }

        public int Evaluate()
        {
            return Value;
        }
    }
}
