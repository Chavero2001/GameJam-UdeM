using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr4_OpposeCriteriaTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : J’ai progressé, même si j’ai encore des erreurs… c’est pas ce qui compte ?" },
            new DialogueLine { text = "Dans une approche normative, c’est le classement qui prime, pas le parcours.", isThought = true },
            new DialogueLine {
                text = "Quelle approche décrivez-vous ici ?",
                isChoice = true,
                choiceA = "Ici, c’est ta place dans le groupe qui compte, pas ton évolution personnelle.",
                choiceB = "Chaque progrès individuel est valorisé, peu importe la position dans la classe.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation normative";
    public int GetAttribute() => 3;
}
