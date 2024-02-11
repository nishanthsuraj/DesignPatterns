namespace CodingInterviewSolutions.DesignPatterns.ChainOfResponsibilityPattern.Handler
{
    internal class OneHundredHandler : CurrencyHandler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 200 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " One Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " One Hundred note is dispatched by TwoHundredHandler");
                }
            }

            //No Need to Check the Next Handler
        }
    }
}
