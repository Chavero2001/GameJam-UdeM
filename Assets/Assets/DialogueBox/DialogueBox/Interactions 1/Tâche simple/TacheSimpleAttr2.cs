using UnityEngine;
using System.Collections.Generic;

public class TacheSimpleAttr2_PasAnalyseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : J�ai juste coch� la bonne case, mais je vois pas en quoi c�est utile." },
            new DialogueLine { text = "Ce type de t�che ne permet pas d�observer le raisonnement, juste la r�ponse finale.", isThought = true },
            new DialogueLine {
                text = "Comment r�agissez-vous ?",
                isChoice = true,
                choiceA = "Tu as raison, cette t�che ne cherche pas � explorer des raisonnements complexes.",
                choiceB = "C�est justement fait pour analyser toutes tes strat�gies.",
                isChoiceACorrect = false // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "T�che simple";
    public int GetAttribute() => 2;
}
