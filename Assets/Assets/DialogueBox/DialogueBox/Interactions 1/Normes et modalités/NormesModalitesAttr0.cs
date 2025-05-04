using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr0_CadreMinistereTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Bilal : Est-ce que c’est toi qui décides des règles d’évaluation ?" },
            new DialogueLine { text = "Il faut lui expliquer que certaines règles me dépassent.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse est la plus juste ?",
                isChoice = true,
                choiceA = "Non, plusieurs règles viennent de directives ministérielles ou de l’école.",
                choiceB = "Oui, chaque enseignant applique les critères comme il veut.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalités";
    public int GetAttribute() => 0;
}
