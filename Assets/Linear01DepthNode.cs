using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.ShaderGraph;
using UnityEngine;

[Title("Custom", "Linear01Depth")]
public class Linear01DepthNode : CodeFunctionNode
{
    public Linear01DepthNode()
    {
        this.name = "Linear01Depth";
    }

    protected override MethodInfo GetFunctionToConvert()
    {
        return GetType().GetMethod("Linear01Depth",
            BindingFlags.Static | BindingFlags.NonPublic);
    }

    static string Linear01Depth(
        [Slot(0, Binding.None)] Vector1 z,
        [Slot(1, Binding.None)] out Vector1 Out)
    {
        return @"
{
    Out = 1.0 / (_ZBufferParams.x * z + _ZBufferParams.y);
} 
";
    }
}
