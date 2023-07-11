using System;
using Godot;

namespace ActionRPG.Scripts.Command;

public partial class UnitCommand: Node
{
    public State CurrentState { get; protected set; }
    public virtual void Execute(Unit unit)
    {
    }

    [Flags]
    public enum State
    {
        Success = 1 << 0,
        Failure = 1 << 1,
        Running = 1 << 2,
    }
}
