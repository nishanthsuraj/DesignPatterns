using CodingInterviewSolutions.DesignPatterns.StatePattern.Enums;

namespace CodingInterviewSolutions.DesignPatterns.StatePattern
{
    internal class SomeCar : Car
    {
        public override void TakeAction(CarAction actionEnum)
        {
            state = (state, actionEnum) switch
            {
                (CarState.Stopped, CarAction.Start) => CarState.Started,
                (CarState.Started, CarAction.Run) => CarState.Running,
                (CarState.Running, CarAction.Stop) => CarState.Stopped,
                (CarState.Started, CarAction.Stop) => CarState.Stopped,
                _ => state,
            };
        }
    }
}
