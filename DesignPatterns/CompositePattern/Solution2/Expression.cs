namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution2
{
    internal class LogicalExpression : IArithmeticExpression
    {
        IArithmeticExpression LeftExpression { get; set; }
        IArithmeticExpression RightExpression { get; set; }
        Operation Operation { get; set; }

        public LogicalExpression(IArithmeticExpression leftExpression,
            IArithmeticExpression rightExpression, Operation operation)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
            Operation = operation;
        }

        public int Evaluate()
        {
            int value = (Operation) switch
            {
                (Operation.Add) => LeftExpression.Evaluate() + RightExpression.Evaluate(),
                (Operation.Subtract) => LeftExpression.Evaluate() - RightExpression.Evaluate(),
                (Operation.Multiply) => LeftExpression.Evaluate() * RightExpression.Evaluate(),
                (Operation.Divide) => LeftExpression.Evaluate() / RightExpression.Evaluate(),
                _ => default,
            };

            return value;
        }
    }
}
