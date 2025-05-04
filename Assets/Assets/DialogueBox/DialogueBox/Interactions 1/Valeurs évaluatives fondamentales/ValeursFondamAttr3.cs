using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr3_ConfianceRelationTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Carlos : J’ai peur de me tromper... à chaque fois que je rends un travail, j’angoisse." },
            new DialogueLine { text = "Cette peur vient d’un manque de sécurité. L’évaluation ne devrait pas provoquer cela.", isThought = true },
            new DialogueLine {
                text = "Comment pouvez-vous rétablir un climat de confiance ?",
                isChoice = true,
                choiceA = "Il faut s’habituer à la pression, ça fait partie du système.",
                choiceB = "Je suis là pour t’aider à progresser, pas pour te piéger. On y va étape par étape.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives fondamentales";
    public int GetAttribute() => 3;
}
