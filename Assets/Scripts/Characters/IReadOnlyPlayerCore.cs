﻿

using System;
using UniRx;
using UnityEngine;

namespace Characters
{
    interface IReadOnlyPlayerCore
    {
        Vector3 Position { get; }
        IObservable<Unit> Dead { get; }
    }
}