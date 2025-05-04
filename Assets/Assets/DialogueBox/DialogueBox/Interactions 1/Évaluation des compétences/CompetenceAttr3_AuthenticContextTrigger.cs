using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr3_AuthenticContextTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Pourquoi on fait une mise en situation ? J�aurais pr�f�r� un quiz rapide." },
            new DialogueLine { text = "Il ne voit pas le lien avec la r�alit�", isThought = true },
            new DialogueLine {
                text = "Comment justifiez-vous l�activit� ?",
                isChoice = true,
                choiceA = "Parce que cette situation ressemble � un vrai contexte o� tu devras mobiliser tes comp�tences.",
                choiceB = "Parce que les quiz sont moins adapt�s au programme actuel.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation des comp�tences";
    public int GetAttribute() => 3;
}
