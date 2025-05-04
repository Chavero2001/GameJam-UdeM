using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr3_QuoiEvaluerTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : Je comprends pas — qu’est-ce qu’on est censés évaluer ici ?" },
            new DialogueLine { text = "Bonne question. D’abord, on définit quoi évaluer, puis comment le communiquer.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous le déroulement de l’évaluation ?",
                isChoice = true,
                choiceA = "On commence par décider quoi évaluer, puis comment communiquer les résultats.",
                choiceB = "On regarde juste la note finale et on passe à autre chose.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Démarche évaluative";
    public int GetAttribute() => 3;
}
