using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr1_FermeeUniqueReponseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Alors… y’avait qu’une bonne réponse pour cette question ? Sérieux ?" },
            new DialogueLine { text = "Oui, et c’est ce qui la rendait si simple à corriger.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous cela ?",
                isChoice = true,
                choiceA = "Oui, parce que cette tâche n’admet qu’une réponse correcte bien définie.",
                choiceB = "Non, toutes les interprétations étaient valides ici.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche simple";
    public int GetAttribute() => 1;
}
