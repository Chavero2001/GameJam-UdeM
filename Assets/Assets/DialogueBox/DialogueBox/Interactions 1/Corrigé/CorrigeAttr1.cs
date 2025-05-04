using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr1_BonnesEtapesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : Je savais pas qu’il fallait écrire les étapes... j’ai juste mis le résultat." },
            new DialogueLine { text = "Le corrigé indiquait clairement les étapes attendues.", isThought = true },
            new DialogueLine {
                text = "Comment l’aidez-vous à comprendre ?",
                isChoice = true,
                choiceA = "C’est le résultat qui compte, pas besoin d’écrire toutes les étapes.",
                choiceB = "Les étapes font partie de la réponse attendue. Elles sont dans le corrigé.",
                isChoiceACorrect = false // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrigé";
    public int GetAttribute() => 1;
}
