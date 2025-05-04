using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr0_RespectIntegriteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Imane : Tu sais, parfois j�ai l�impression qu�on est juste des chiffres pour certains profs." },
            new DialogueLine { text = "Elle cherche � �tre reconnue, pas r�duite � une note.", isThought = true },
            new DialogueLine {
                text = "Comment lui montrez-vous qu�elle est entendue ?",
                isChoice = true,
                choiceA = "Tu es bien plus que �a. L��valuation devrait refl�ter qui tu es, pas seulement un r�sultat.",
                choiceB = "Les notes sont l� pour classer, on ne peut pas y mettre d��motion.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives fondamentales";
    public int GetAttribute() => 0;
}
