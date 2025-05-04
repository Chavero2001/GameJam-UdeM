using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr2_SelectionTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On va choisir qui passe à l’étape suivante, non ? Genre, les meilleurs ?" },
            new DialogueLine { text = "Il pense comme dans un concours…", isThought = true },
            new DialogueLine {
                text = "Comment réagissez-vous ?",
                isChoice = true,
                choiceA = "Oui, l’objectif est de distinguer les plus performants pour avancer.",
                choiceB = "Non, tout le monde doit atteindre les critères, peu importe leur classement.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation normative";
    public int GetAttribute() => 1;
}
