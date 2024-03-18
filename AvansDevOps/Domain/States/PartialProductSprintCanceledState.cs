﻿using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class PartialProductSprintCanceledState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintCanceledState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CancelRelease()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.CancelSprint()
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeName(string name)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.FinishSprint()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.Release()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been canceled and can not be started!");
        }
    }
}
