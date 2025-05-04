using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr3_EvaluerCompetencesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : J�imagine que c�est pas juste un exercice... c�est pour voir ce qu�on sait vraiment faire ?" },
            new DialogueLine { text = "Exactement. Cette t�che sert � �valuer la comp�tence globale.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse appuyez-vous ?",
                isChoice = true,
                choiceA = "Oui, cette t�che sert � v�rifier si tu ma�trises une comp�tence dans son ensemble.",
                choiceB = "Pas forc�ment. C�est juste une autre activit� sans objectif pr�cis.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che complexe";
    public int GetAttribute() => 3;
}
