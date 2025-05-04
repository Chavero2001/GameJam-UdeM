using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr0_DecisionAdaptationTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Zahra : J�ai remarqu� que la moiti� du groupe a mal r�ussi la t�che. Tu vas leur donner une autre chance ?" },
            new DialogueLine { text = "Est-ce que j�utilise les r�sultats pour ajuster ma p�dagogie ?", isThought = true },
            new DialogueLine {
                text = "Quelle serait une r�ponse professionnelle ?",
                isChoice = true,
                choiceA = "Oui, ces r�sultats me servent � voir ce que je dois reprendre ou r�expliquer.",
                choiceB = "Non, ce qui est fait est fait. Le but, c��tait l��valuation, pas l�adaptation.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives instrumentales";
    public int GetAttribute() => 0;
}
