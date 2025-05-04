using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr1_ComparaisonSoiTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Kenji : J�ai pas la m�me note que Sabrine� pourtant, j�ai fait mieux que la derni�re fois !" },
            new DialogueLine { text = "Il �value son progr�s par rapport � lui-m�me. Et il a raison de le souligner.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse appuie cette vision ?",
                isChoice = true,
                choiceA = "On �value en fonction du groupe. Ce que les autres font compte aussi.",
                choiceB = "Ce qui compte ici, c�est ta propre �volution, pas ta comparaison avec les autres.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation dynamique";
    public int GetAttribute() => 1;
}
