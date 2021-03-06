﻿using System;

namespace Wizardry.ViewModels
{
    public interface IStep : Wizardry.IStep
    {
        event Action<Wizardry.IStep> OnExecute;
        event Action<Wizardry.IStep> OnLoad;
        string Title { get; }
    }
}
