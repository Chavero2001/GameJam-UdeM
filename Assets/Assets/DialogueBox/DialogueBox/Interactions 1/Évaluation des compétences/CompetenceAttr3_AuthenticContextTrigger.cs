using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr3_AuthenticContextTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Pourquoi on fait une mise en situation ? J’aurais préféré un quiz rapide." },
            new DialogueLine { text = "Il ne voit pas le lien avec la réalité…", isThought = true },
            new DialogueLine {
                text = "Comment justifiez-vous l’activité ?",
                isChoice = true,
                choiceA = "Parce que cette situation ressemble à un vrai contexte où tu devras mobiliser tes compétences.",
                choiceB = "Parce que les quiz sont moins adaptés au programme actuel.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation des compétences";
    public int GetAttribute() => 3;
}
