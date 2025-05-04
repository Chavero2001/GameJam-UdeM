using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr3_QuoiEvaluerTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : Je comprends pas � qu�est-ce qu�on est cens�s �valuer ici ?" },
            new DialogueLine { text = "Bonne question. D�abord, on d�finit quoi �valuer, puis comment le communiquer.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous le d�roulement de l��valuation ?",
                isChoice = true,
                choiceA = "On commence par d�cider quoi �valuer, puis comment communiquer les r�sultats.",
                choiceB = "On regarde juste la note finale et on passe � autre chose.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "D�marche �valuative";
    public int GetAttribute() => 3;
}
