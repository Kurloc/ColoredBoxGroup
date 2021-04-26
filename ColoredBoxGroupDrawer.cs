using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

    
#pragma warning disable

using UnityEngine;


public class ColoredBoxGroupDrawer : OdinGroupDrawer<ColoredBoxGroupAttribute> 
{

    /// <summary>
    /// Draw the stuff
    /// </summary>
    /// <param name="label">Label string</param>
    protected override void DrawPropertyLayout(GUIContent label)
    {

        string headerLabel = Attribute.LabelText;
        if (Attribute.ShowLabel)
        {
            if (string.IsNullOrEmpty(Attribute.LabelText))
            {
                headerLabel = "";
            }
        }
        
        GUIHelper.PushColor(new Color(Attribute.R, Attribute.G, Attribute.B, Attribute.A));
        SirenixEditorGUI.BeginBox();
        SirenixEditorGUI.BeginBoxHeader();
        GUIHelper.PopColor(); 
        
        SirenixEditorGUI.Title(headerLabel, null, TextAlignment.Left, false, Attribute.BoldLabel);
        SirenixEditorGUI.EndBoxHeader();

        for (int i = 0; i < Property.Children.Count; i++)
        {
            Property.Children[i].Draw();
        }

        SirenixEditorGUI.EndBox();
    }
}
