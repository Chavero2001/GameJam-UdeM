using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr2_ProcessEtProduitTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : Mon résultat est correct, peu importe comment j’y suis arrivée, non ?" },
            new DialogueLine { text = "Mais si elle a deviné ? Le résultat ne raconte pas tout.", isThought = true },
            new DialogueLine {
                text = "Quelle perspective adoptez-vous ?",
                isChoice = true,
                choiceA = "Le résultat est bon, mais je veux aussi comprendre comment tu y es parvenue.",
                choiceB = "Oui, seul le résultat compte tant qu’il est juste.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation des compétences";
    public int GetAttribute() => 2;
}
