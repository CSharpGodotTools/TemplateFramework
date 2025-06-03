using Godot;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace GodotUtils;

public static class Debug
{
    public static void ThrowIfNull(Node node, object obj, [CallerArgumentExpression(nameof(obj))] string paramName = "")
    {
        ArgumentNullException.ThrowIfNull(node, nameof(node));

        if (obj == null)
        {
            string scriptName = Path.GetFileName(node?.GetScript().As<Script>().ResourcePath);

            node.SetPhysicsProcess(false);
            node.SetProcess(false);

            throw new Exception($"Value cannot be null. (Parameter '{paramName}' in {scriptName})");
        }
    }
}
