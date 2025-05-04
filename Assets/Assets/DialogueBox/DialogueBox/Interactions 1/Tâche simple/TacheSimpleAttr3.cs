using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr3_ConnaissanceIsoléeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : J’ai déjà fait cet exercice plein de fois, c’est toujours pareil." },
            new DialogueLine { text = "C’est justement le but : vérifier une routine bien maîtrisée.", isThought = true },
            new DialogueLine {
                text = "Comment le confirmez-vous ?",
                isChoice = true,
                choiceA = "Exactement. Cette tâche vérifie une connaissance isolée que tu as pratiquée.",
                choiceB = "Non, elle change à chaque fois pour tester ta flexibilité.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche simple";
    public int GetAttribute() => 3;
}
