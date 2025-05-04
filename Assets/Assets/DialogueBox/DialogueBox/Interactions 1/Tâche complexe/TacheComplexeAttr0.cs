using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr0_CombinerRessourcesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Ce devoir est trop compliqu� faut utiliser des trucs de plusieurs mati�res !" },
            new DialogueLine { text = "Justement, c�est une t�che qui demande de croiser plusieurs ressources.", isThought = true },
            new DialogueLine {
                text = "Comment l�orientez-vous ?",
                isChoice = true,
                choiceA = "Concentre-toi sur une seule notion, ce sera plus simple.",
                choiceB = "C�est pr�vu ainsi : il faut mobiliser plusieurs ressources pour y r�pondre.",
                isChoiceACorrect = true // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che complexe";
    public int GetAttribute() => 0;
}
