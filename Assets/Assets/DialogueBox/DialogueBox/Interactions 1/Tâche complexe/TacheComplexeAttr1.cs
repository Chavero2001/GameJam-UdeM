using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr1_ContexteReelTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : On dirait une vraie situation de travail, ce projet !" },
            new DialogueLine { text = "Exactement. L�id�e est de te plonger dans un contexte authentique.", isThought = true },
            new DialogueLine {
                text = "Comment le confirmez-vous ?",
                isChoice = true,
                choiceA = "Oui, c�est volontaire : la t�che imite une situation r�elle.",
                choiceB = "Non, c�est juste une co�ncidence si �a ressemble � la vraie vie.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che complexe";
    public int GetAttribute() => 1;
}
