using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr0_NormeGroupeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Hassan : J’ai eu 75%... mais est-ce que c’est bien ? Ça dépend de quoi, en fait ?" },
            new DialogueLine { text = "Il cherche un repère... mais il ne parle pas de critères, il veut se situer par rapport aux autres.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse l’aiderait à mieux comprendre ?",
                isChoice = true,
                choiceA = "Peu importe les autres, l’important c’est ton progrès personnel.",
                choiceB = "Ça dépend de la moyenne générale ou du niveau attendu dans le groupe.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation normative";
    public int GetAttribute() => 0;
}
