using UnityEngine;

/// <summary>
/// A structured data model for a single dialogue entry.
/// Supports regular lines, internal thoughts, and choices.
/// </summary>
[System.Serializable] // Required for Unity to serialize this class inside lists or custom editors
public class DialogueLine
{
    [TextArea] // Optional: Enables multi-line editing in Inspector
    public string text;               // The text content of the dialogue line

    public bool isThought = false;    // Marks this line as an internal thought
    public bool isChoice = false;     // Marks this line as a branching choice

    public string choiceA;            // Text for option A (if isChoice = true)
    public string choiceB;            // Text for option B (if isChoice = true)
    public bool isChoiceACorrect;     // Defines which option is correct (true = A, false = B)
}
