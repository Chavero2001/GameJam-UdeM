using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr0_RessourceUniqueTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : Cet exercice-là... c’est juste pour voir si on sait conjuguer, hein ?" },
            new DialogueLine { text = "Exact. Pas besoin de plus pour cette tâche précise.", isThought = true },
            new DialogueLine {
                text = "Comment clarifiez-vous l’objectif ?",
                isChoice = true,
                choiceA = "Oui, elle vise une seule habileté bien précise.",
                choiceB = "Non, il faut utiliser toutes les compétences en même temps.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche simple";
    public int GetAttribute() => 0;
}
