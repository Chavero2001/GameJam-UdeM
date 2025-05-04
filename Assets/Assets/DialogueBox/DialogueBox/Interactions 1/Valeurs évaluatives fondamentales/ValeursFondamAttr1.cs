using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr1_JusticeEquiteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Andrei : Est-ce que c’est juste si on a tous exactement la même tâche, même si certains ont plus de difficultés ?" },
            new DialogueLine { text = "Sa question soulève l’enjeu d’équité… ce n’est pas la même chose que l’égalité.", isThought = true },
            new DialogueLine {
                text = "Comment réagissez-vous ?",
                isChoice = true,
                choiceA = "Oui, on donne la même chose à tout le monde pour être équitable.",
                choiceB = "L’équité, c’est offrir à chacun ce dont il a besoin pour réussir.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives fondamentales";
    public int GetAttribute() => 1;
}
