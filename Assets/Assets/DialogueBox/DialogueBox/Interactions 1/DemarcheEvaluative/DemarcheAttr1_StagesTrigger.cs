using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr1_StagesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On a vraiment besoin de planifier tout ce truc d’évaluation ?" },
            new DialogueLine { text = "Il ne se rend pas compte que l’évaluation suit des étapes...", isThought = true },
            new DialogueLine {
                text = "Que répondez-vous ?",
                isChoice = true,
                choiceA = "Oui, l’évaluation comporte cinq étapes, de la planification à la communication des résultats.",
                choiceB = "Pas vraiment, on donne juste une note à la fin.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Démarche évaluative";
    public int GetAttribute() => 0;
}
