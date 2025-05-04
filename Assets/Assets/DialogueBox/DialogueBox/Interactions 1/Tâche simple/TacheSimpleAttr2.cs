using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr2_PasAnalyseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : J’ai juste coché la bonne case, mais je vois pas en quoi c’est utile." },
            new DialogueLine { text = "Ce type de tâche ne permet pas d’observer le raisonnement, juste la réponse finale.", isThought = true },
            new DialogueLine {
                text = "Comment réagissez-vous ?",
                isChoice = true,
                choiceA = "Tu as raison, cette tâche ne cherche pas à explorer des raisonnements complexes.",
                choiceB = "C’est justement fait pour analyser toutes tes stratégies.",
                isChoiceACorrect = false // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche simple";
    public int GetAttribute() => 2;
}
