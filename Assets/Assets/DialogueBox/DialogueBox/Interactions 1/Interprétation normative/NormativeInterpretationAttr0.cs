using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr0_NormeGroupeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Hassan : J�ai eu 75%... mais est-ce que c�est bien ? �a d�pend de quoi, en fait ?" },
            new DialogueLine { text = "Il cherche un rep�re... mais il ne parle pas de crit�res, il veut se situer par rapport aux autres.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse l�aiderait � mieux comprendre ?",
                isChoice = true,
                choiceA = "Peu importe les autres, l�important c�est ton progr�s personnel.",
                choiceB = "�a d�pend de la moyenne g�n�rale ou du niveau attendu dans le groupe.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation normative";
    public int GetAttribute() => 0;
}
