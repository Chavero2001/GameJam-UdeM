using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr0_ModeleReponseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : J�ai corrig� les copies... un peu au feeling, tu sais ?" },
            new DialogueLine { text = "Elle n�a m�me pas regard� le corrig�", isThought = true },
            new DialogueLine {
                text = "Comment r�agissez-vous ?",
                isChoice = true,
                choiceA = "C�est bien si tu y vas � l�instinct. Tu connais les bonnes r�ponses, non ?",
                choiceB = "Il vaut mieux te baser sur le corrig� pr�vu pour assurer l��quit�.",
                isChoiceACorrect = false // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrig�";
    public int GetAttribute() => 0;
}
