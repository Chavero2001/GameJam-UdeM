using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr3_IncompatibleSommatifTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Rosa : J’ai pas bien compris... mais maintenant j’ai une mauvaise note et c’est fini ?" },
            new DialogueLine { text = "Elle associe l’évaluation à une sanction. Est-ce que je renforce ou j’ouvre ?", isThought = true },
            new DialogueLine {
                text = "Comment répondez-vous ?",
                isChoice = true,
                choiceA = "Tu devras faire mieux la prochaine fois. Cette note reste au dossier.",
                choiceB = "Ce travail était pour te guider. On va le reprendre ensemble pour progresser.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide à l’apprentissage";
    public int GetAttribute() => 3;
}
