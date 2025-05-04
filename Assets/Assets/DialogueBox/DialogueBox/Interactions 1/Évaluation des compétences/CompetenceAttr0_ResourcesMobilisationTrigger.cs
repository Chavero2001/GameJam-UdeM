using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr0_ResourcesMobilisationTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Si j�apprends la formule par c�ur, j�aurai la bonne note, non ?" },
            new DialogueLine { text = "Il croit qu�une seule connaissance suffit� mais ce n�est pas un test de m�moire.", isThought = true },
            new DialogueLine {
                text = "Quelle est la meilleure fa�on d��valuer la comp�tence ?",
                isChoice = true,
                choiceA = "Il faut voir si tu peux utiliser plusieurs connaissances et strat�gies ensemble.",
                choiceB = "Oui, tant que tu sais la formule, c�est suffisant.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation des comp�tences";
    public int GetAttribute() => 0;
}
