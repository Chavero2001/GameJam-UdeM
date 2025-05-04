using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr0_ProgressionTempsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Amara : J��tais nulle au d�but... mais l�, j�ai compris. Est-ce que �a compte ?" },
            new DialogueLine { text = "Elle veut savoir si ses efforts dans le temps sont reconnus.", isThought = true },
            new DialogueLine {
                text = "Comment r�pondez-vous ?",
                isChoice = true,
                choiceA = "Bien s�r. C�est ta progression depuis le d�part qui m�int�resse ici.",
                choiceB = "Non, on regarde seulement le r�sultat final, pas l��volution.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation dynamique";
    public int GetAttribute() => 0;
}
