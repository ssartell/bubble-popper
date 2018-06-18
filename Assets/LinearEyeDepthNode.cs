using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.ShaderGraph;
using UnityEngine;

[Title("Custom", "LinearEyeDepth")]
public class LinearEyeDepthNode : CodeFunctionNode
{
    public LinearEyeDepthNode()
    {
        this.name = "LinearEyeDepth";
    }

    protected override MethodInfo GetFunctionToConvert()
    {
        return GetType().GetMethod("LinearEyeDepth",
            BindingFlags.Static | BindingFlags.NonPublic);
    }

    static string LinearEyeDepth(
        [Slot(0, Binding.None)] Vector1 z,
        [Slot(1, Binding.None)] out Vector1 Out)
    {
        return @"
{
    
	Out = 1.0 / (_ZBufferParams.z * z + _ZBufferParams.w);
} 
";
    }
}
