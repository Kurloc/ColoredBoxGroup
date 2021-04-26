using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

    
#pragma warning disable

using UnityEngine;
using Sirenix.OdinInspector.Editor.ValueResolvers;


public class ColoredBoxGroupDrawer : OdinGroupDrawer<ColoredBoxGroupAttribute> 
{
    private ValueResolver<string> labelGetter;

    
    /// <summary>
    /// initialize values for colors, labels, etc
    /// </summary>
    protected override void Initialize()
    {
        labelGetter = ValueResolver.GetForString(Property, Attribute.LabelText ?? Attribute.GroupName);
    }

    
    /// <summary>
    /// Draw the stuff
    /// </summary>
    /// <param name="label">Label string</param>
    protected override void DrawPropertyLayout(GUIContent label)
    {
        GUIHelper.PushColor(new Color(Attribute.R, Attribute.G, Attribute.B, Attribute.A));
        labelGetter.DrawError();

        string headerLabel = null;
        if (Attribute.ShowLabel)
        {
            headerLabel = labelGetter.GetValue();
            if (string.IsNullOrEmpty(headerLabel))
            {
                headerLabel = "";
            }
        }
        
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
