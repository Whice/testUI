using System;


/// <summary>
/// Attribute from method
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class EditorButtonAttribute : Attribute
{
    /// <summary>
    /// Button text
    /// </summary>
    public string buttonText;

    /// <summary>
    /// Add Button to Inspector
    /// </summary>
    /// <param name="buttonText">Button text</param>
    public EditorButtonAttribute(string buttonText)
    {
        this.buttonText = buttonText;
    }
}