using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr1_StagesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On a vraiment besoin de planifier tout ce truc d��valuation ?" },
            new DialogueLine { text = "Il ne se rend pas compte que l��valuation suit des �tapes...", isThought = true },
            new DialogueLine {
                text = "Que r�pondez-vous ?",
                isChoice = true,
                choiceA = "Oui, l��valuation comporte cinq �tapes, de la planification � la communication des r�sultats.",
                choiceB = "Pas vraiment, on donne juste une note � la fin.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "D�marche �valuative";
    public int GetAttribute() => 0;
}
