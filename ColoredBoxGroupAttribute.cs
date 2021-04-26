using System;
using Sirenix.OdinInspector;


#pragma warning disable
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
[global::System.Diagnostics.Conditional("UNITY_EDITOR")]
public class ColoredBoxGroupAttribute : BoxGroupAttribute
{
    public float R, G, B, A;
    public bool BoldLabel;
    public string LabelText;


    public ColoredBoxGroupAttribute(
        string @group,
        string label,
        float r, float g, float b, float a,
        bool showLabel = true,
        bool centerLabel = false,
        bool boldLabel = false,
        float order = 0) : base(@group, showLabel, centerLabel, order)
    {
        R = r;
        G = g;
        B = b;
        A = a;

        LabelText = label;
        BoldLabel = boldLabel;
    }
}
