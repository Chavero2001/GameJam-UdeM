using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr1_MomentsFormatsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Sophie : Pourquoi on a un test cette semaine ? Et pourquoi �a compte autant ?" },
            new DialogueLine { text = "Elle veut comprendre la logique derri�re la planification �valuative.", isThought = true },
            new DialogueLine {
                text = "Comment r�pondez-vous ?",
                isChoice = true,
                choiceA = "Je choisis les dates et pond�rations selon mes pr�f�rences p�dagogiques.",
                choiceB = "Le calendrier et la pond�ration sont pr�cis�s dans les normes d��valuation de l��cole.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalit�s";
    public int GetAttribute() => 1;
}
