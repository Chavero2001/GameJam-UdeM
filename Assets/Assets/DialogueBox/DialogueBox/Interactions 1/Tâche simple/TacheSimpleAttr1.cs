using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr1_FermeeUniqueReponseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Alors� y�avait qu�une bonne r�ponse pour cette question ? S�rieux ?" },
            new DialogueLine { text = "Oui, et c�est ce qui la rendait si simple � corriger.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous cela ?",
                isChoice = true,
                choiceA = "Oui, parce que cette t�che n�admet qu�une r�ponse correcte bien d�finie.",
                choiceB = "Non, toutes les interpr�tations �taient valides ici.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che simple";
    public int GetAttribute() => 1;
}
