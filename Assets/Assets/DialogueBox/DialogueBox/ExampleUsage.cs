using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Simple trigger to test or launch a dialogue interaction.
/// Attach this to any GameObject and assign the DialogueBoxLegacy reference in the Inspector.
/// </summary>
public class DialogueTrigger : MonoBehaviour
{
    public DialogueBoxLegacy dialogueBox;  // Reference to the dialogue box system (assign in Inspector)

    // You can either call this from Start (auto-play) or trigger it from another event
    void Start()
    {
        // Example dialogue lines for testing
        List<DialogueLine> lines = new List<DialogueLine>()
        {
            // Regular dialogue line
            new DialogueLine { text = "Finley: I hope you like it!" },

            // Thought line (displayed with visual indication)
            new DialogueLine { text = "This student gives a fishy feeling...", isThought = true },

            // Choice line with two options and one correct answer
            new DialogueLine {
                text = "How should I evaluate this?",
                isChoice = true,
                choiceA = "Compare to task requirements",   // Correct
                choiceB = "Go with your gut",               // Incorrect
                isChoiceACorrect = true
            }
        };

        // Start the dialogue
        dialogueBox.StartDialogue(lines);
    }

    // Optional: Create a public method to trigger the same dialogue manually
    // This is useful if you want to launch it via a button or collision trigger
    public void TriggerDialogue()
    {
        Start();
    }
}
