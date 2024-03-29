﻿namespace AvansDevOps.Domain.States.Abstracts
{
    internal interface IReleaseSprintState : ISprintState
    {
        //hier logica om door het state pattern heen te lopen
        void StartSprint();
        void FinishSprint();
        void CancelSprint();
        void Release();
        void CancelRelease();
    }
}