using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr2_FormelleDiplomeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Jade : � la fin de l�ann�e, qu�est-ce qui prouve ce que j�ai vraiment appris ?" },
            new DialogueLine { text = "Elle cherche � comprendre comment ses acquis sont officiellement valid�s.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse donne du sens � cette reconnaissance ?",
                isChoice = true,
                choiceA = "On n�a pas besoin de document formel, c�est plut�t entre toi et moi.",
                choiceB = "Ton bulletin et ton dipl�me sont des preuves formelles de ce que tu as d�montr�.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des comp�tences";
    public int GetAttribute() => 2;
}
