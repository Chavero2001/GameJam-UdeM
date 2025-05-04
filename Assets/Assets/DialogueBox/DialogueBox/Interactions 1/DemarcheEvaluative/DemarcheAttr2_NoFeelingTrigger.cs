using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr2_NoFeelingTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : J’espère que ça ira... Je suis toujours nerveux de montrer mon travail." },
            new DialogueLine { text = "Cet élève m’inspire confiance… mais je dois rester objectif.", isThought = true },
            new DialogueLine {
                text = "Qu’est-ce qui doit guider votre jugement ?",
                isChoice = true,
                choiceA = "Se fier à ce que vous ressentez.",
                choiceB = "Suivre la démarche pour éviter de juger « au feeling ».",
                isChoiceACorrect = false // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Démarche évaluative";
    public int GetAttribute() => 1;
}
