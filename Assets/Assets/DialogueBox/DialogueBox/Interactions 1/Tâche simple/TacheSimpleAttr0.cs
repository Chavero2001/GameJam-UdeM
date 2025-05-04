using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr0_RessourceUniqueTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : Cet exercice-l�... c�est juste pour voir si on sait conjuguer, hein ?" },
            new DialogueLine { text = "Exact. Pas besoin de plus pour cette t�che pr�cise.", isThought = true },
            new DialogueLine {
                text = "Comment clarifiez-vous l�objectif ?",
                isChoice = true,
                choiceA = "Oui, elle vise une seule habilet� bien pr�cise.",
                choiceB = "Non, il faut utiliser toutes les comp�tences en m�me temps.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che simple";
    public int GetAttribute() => 0;
}
