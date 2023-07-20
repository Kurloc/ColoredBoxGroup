using System;
using Sirenix.OdinInspector;


// #pragma warning disable
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
[System.Diagnostics.Conditional("UNITY_EDITOR")]
public class ColoredBoxGroupAttribute : BoxGroupAttribute
{
    public readonly float R, G, B, A;
    public readonly bool  BoldLabel;

    public int MarginTop    { get; set; }
    public int MarginBottom { get; set; }

    public ColoredBoxGroupAttribute(
        string @group,
        float  r = 0,
        float  g = 0,
        float  b = 0,
        float  a = 0,
        int    marginTop   = 0,
        bool   showLabel   = true,
        bool   centerLabel = false,
        bool   boldLabel   = false,
        float  order       = 0
    ) : base(@group, showLabel, centerLabel, order)
    {
        R         = r;
        G         = g;
        B         = b;
        A         = a;
        MarginTop = marginTop;

        BoldLabel = boldLabel;
    }

    public ColoredBoxGroupAttribute(
        string @group,
        string label,
        float  r = 0,
        float  g = 0,
        float  b = 0,
        float  a = 0,
        int    marginTop   = 0,
        bool   showLabel   = true,
        bool   centerLabel = false,
        bool   boldLabel   = false,
        float  order       = 0
    ) : base(@group, showLabel, centerLabel, order)
    {
        R         = r;
        G         = g;
        B         = b;
        A         = a;
        MarginTop = marginTop;
        LabelText = label;
        BoldLabel = boldLabel;
    }
}
