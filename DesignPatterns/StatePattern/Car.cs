using CodingInterviewSolutions.DesignPatterns.StatePattern.Enums;

namespace CodingInterviewSolutions.DesignPatterns.StatePattern
{
    internal abstract class Car
    {
        #region Protected Variable
        protected CarState state = CarState.Stopped;

        #endregion

        #region Public Property
        public CarState CurrentState { get => state; }

        #endregion

        #region Abstract Method
        public abstract void TakeAction(CarAction actionEnum);

        #endregion
    }
}
