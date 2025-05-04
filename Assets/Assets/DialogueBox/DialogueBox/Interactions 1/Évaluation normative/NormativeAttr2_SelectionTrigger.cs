using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr2_SelectionTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On va choisir qui passe � l��tape suivante, non ? Genre, les meilleurs ?" },
            new DialogueLine { text = "Il pense comme dans un concours�", isThought = true },
            new DialogueLine {
                text = "Comment r�agissez-vous ?",
                isChoice = true,
                choiceA = "Oui, l�objectif est de distinguer les plus performants pour avancer.",
                choiceB = "Non, tout le monde doit atteindre les crit�res, peu importe leur classement.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation normative";
    public int GetAttribute() => 1;
}
