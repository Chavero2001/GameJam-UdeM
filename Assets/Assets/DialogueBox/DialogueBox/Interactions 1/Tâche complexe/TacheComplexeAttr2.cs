using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr2_ReponsesMultiplesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : J�ai pas la m�me r�ponse que Max, mais on a tous les deux eu des bons points ?" },
            new DialogueLine { text = "Ils ont emprunt� deux chemins valables vers la solution.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous cela ?",
                isChoice = true,
                choiceA = "Oui, plusieurs d�marches peuvent mener � un r�sultat pertinent.",
                choiceB = "Non, une seule m�thode �tait attendue, mais on a �t� indulgents.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che complexe";
    public int GetAttribute() => 2;
}
