using UnityEngine;
using System.Collections.Generic;

public class OutilJugementAttr2_FormeGrilleBaremeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : Ce tableau avec les cases à cocher... c’est vraiment utile ?" },
            new DialogueLine { text = "Oui, c’est justement une des formes d’outil de jugement les plus courantes.", isThought = true },
            new DialogueLine {
                text = "Comment lui répondez-vous ?",
                isChoice = true,
                choiceA = "Oui, une grille ou un barème permet de structurer l’évaluation.",
                choiceB = "Pas vraiment, c’est plus décoratif qu’autre chose.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Outil de jugement";
    public int GetAttribute() => 2;
}
