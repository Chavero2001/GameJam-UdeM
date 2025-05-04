using UnityEngine;
using System.Collections.Generic;

public class OutilJugementAttr0_Crit�resDescripteursTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On note juste sur 10 ? Genre... au pif ?" },
            new DialogueLine { text = "Non. On a des crit�res, des niveaux, et des indicateurs bien d�finis.", isThought = true },
            new DialogueLine {
                text = "Comment pr�cisez-vous le fonctionnement ?",
                isChoice = true,
                choiceA = "On utilise des crit�res, des descripteurs et une �chelle pour �valuer avec pr�cision.",
                choiceB = "On attribue les points selon l�impression g�n�rale que �a donne.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Outil de jugement";
    public int GetAttribute() => 0;
}
