using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr3_AideApprentissageTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Luis : Donc ce n’est pas pour une note finale... c’est juste pour qu’on progresse ?" },
            new DialogueLine { text = "Exactement. C’est une évaluation pour apprendre, pas pour sanctionner.", isThought = true },
            new DialogueLine {
                text = "Quelle explication renforce cette idée ?",
                isChoice = true,
                choiceA = "Non, cette évaluation servira à établir un classement final.",
                choiceB = "Oui, c’est surtout pour t’aider à identifier ce que tu peux encore développer.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation dynamique";
    public int GetAttribute() => 3;
}
