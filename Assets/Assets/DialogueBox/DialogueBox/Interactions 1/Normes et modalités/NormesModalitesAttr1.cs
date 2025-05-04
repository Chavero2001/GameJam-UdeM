using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr1_MomentsFormatsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Sophie : Pourquoi on a un test cette semaine ? Et pourquoi ça compte autant ?" },
            new DialogueLine { text = "Elle veut comprendre la logique derrière la planification évaluative.", isThought = true },
            new DialogueLine {
                text = "Comment répondez-vous ?",
                isChoice = true,
                choiceA = "Je choisis les dates et pondérations selon mes préférences pédagogiques.",
                choiceB = "Le calendrier et la pondération sont précisés dans les normes d’évaluation de l’école.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalités";
    public int GetAttribute() => 1;
}
