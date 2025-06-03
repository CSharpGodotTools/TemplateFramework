using System;

namespace GodotUtils;

public class State(string name = "")
{
    public Action Enter { get; set; } = () => { };
    public Action<double> Update { get; set; } = _ => { };
    public Action Exit { get; set; } = () => { };

    private readonly string _name = name;
    
    public override string ToString() => _name.ToLower();
}

public interface IStateMachine
{
    void SwitchState(State newState);
}
