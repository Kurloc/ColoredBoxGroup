#if UNITY_EDITOR
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEngine;

public class ColoredBoxGroupDrawer : OdinGroupDrawer<ColoredBoxGroupAttribute> 
{
    /// <summary>
    /// Draw the stuff
    /// </summary>
    /// <param name="label">Label string</param>
    protected override void DrawPropertyLayout(GUIContent label)
    {
        GUILayout.Space(Attribute.MarginTop);

        var headerLabel = Attribute.LabelText;

        if (Attribute.ShowLabel)
        {
            if (string.IsNullOrEmpty(headerLabel))
            {
                headerLabel = "";
            }
        }

        GUIHelper.PushColor(new Color(Attribute.R, Attribute.G, Attribute.B, Attribute.A));   
        SirenixEditorGUI.BeginBox();
        SirenixEditorGUI.BeginBoxHeader();
        {
            GUIHelper.PopColor();

            if (Attribute.ShowLabel)
            {
                SirenixEditorGUI.Title(headerLabel, null,
                                       Attribute.CenterLabel ? TextAlignment.Center : TextAlignment.Left, false,
                                       Attribute.BoldLabel);
            }
        }
        SirenixEditorGUI.EndBoxHeader();

        foreach (var t in Property.Children)
        {
            t.Draw();
        }

        SirenixEditorGUI.EndBox();

        GUILayout.Space(Attribute.MarginBottom);
    }
}
#endif
