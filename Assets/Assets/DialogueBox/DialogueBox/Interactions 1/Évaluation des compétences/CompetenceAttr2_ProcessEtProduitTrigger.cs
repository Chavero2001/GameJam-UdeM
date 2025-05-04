using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr2_ProcessEtProduitTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : Mon r�sultat est correct, peu importe comment j�y suis arriv�e, non ?" },
            new DialogueLine { text = "Mais si elle a devin� ? Le r�sultat ne raconte pas tout.", isThought = true },
            new DialogueLine {
                text = "Quelle perspective adoptez-vous ?",
                isChoice = true,
                choiceA = "Le r�sultat est bon, mais je veux aussi comprendre comment tu y es parvenue.",
                choiceB = "Oui, seul le r�sultat compte tant qu�il est juste.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation des comp�tences";
    public int GetAttribute() => 2;
}
