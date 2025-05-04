using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr1_ComparisonTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : J�ai eu 78%, mais si tout le monde a eu plus, est-ce que j�ai �chou� ?" },
            new DialogueLine { text = "Elle cherche une r�ponse� mais selon quel rep�re ?", isThought = true },
            new DialogueLine {
                text = "Comment r�pondez-vous ?",
                isChoice = true,
                choiceA = "�a d�pend de la moyenne de la classe. On regarde comment tu te situes par rapport aux autres.",
                choiceB = "L�important, c�est ce que toi tu as appris, pas ce que les autres ont fait.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation normative";
    public int GetAttribute() => 0;
}
