using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr1_ApprocheCompetenceTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Samuel : Tu veux voir si je comprends... mais pas juste si j�ai bon ?" },
            new DialogueLine { text = "Il touche du doigt l�approche par comp�tence.", isThought = true },
            new DialogueLine {
                text = "Comment r�pondez-vous ?",
                isChoice = true,
                choiceA = "Exactement. Ce n�est pas une note brute, on regarde comment tu mobilises tes acquis.",
                choiceB = "Pas vraiment. Ici, on juge juste le r�sultat.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation crit�ri�e";
    public int GetAttribute() => 1;
}
