using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr3_ConfianceRelationTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Carlos : J�ai peur de me tromper... � chaque fois que je rends un travail, j�angoisse." },
            new DialogueLine { text = "Cette peur vient d�un manque de s�curit�. L��valuation ne devrait pas provoquer cela.", isThought = true },
            new DialogueLine {
                text = "Comment pouvez-vous r�tablir un climat de confiance ?",
                isChoice = true,
                choiceA = "Il faut s�habituer � la pression, �a fait partie du syst�me.",
                choiceB = "Je suis l� pour t�aider � progresser, pas pour te pi�ger. On y va �tape par �tape.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives fondamentales";
    public int GetAttribute() => 3;
}
