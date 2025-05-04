using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr0_CombinerRessourcesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Ce devoir est trop compliqué… faut utiliser des trucs de plusieurs matières !" },
            new DialogueLine { text = "Justement, c’est une tâche qui demande de croiser plusieurs ressources.", isThought = true },
            new DialogueLine {
                text = "Comment l’orientez-vous ?",
                isChoice = true,
                choiceA = "Concentre-toi sur une seule notion, ce sera plus simple.",
                choiceB = "C’est prévu ainsi : il faut mobiliser plusieurs ressources pour y répondre.",
                isChoiceACorrect = true // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche complexe";
    public int GetAttribute() => 0;
}
