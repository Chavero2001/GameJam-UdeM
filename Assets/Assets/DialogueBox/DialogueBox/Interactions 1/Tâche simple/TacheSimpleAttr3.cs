using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr3_ConnaissanceIsol�eTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : J�ai d�j� fait cet exercice plein de fois, c�est toujours pareil." },
            new DialogueLine { text = "C�est justement le but : v�rifier une routine bien ma�tris�e.", isThought = true },
            new DialogueLine {
                text = "Comment le confirmez-vous ?",
                isChoice = true,
                choiceA = "Exactement. Cette t�che v�rifie une connaissance isol�e que tu as pratiqu�e.",
                choiceB = "Non, elle change � chaque fois pour tester ta flexibilit�.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che simple";
    public int GetAttribute() => 3;
}
