using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr2_FormelleDiplomeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Jade : À la fin de l’année, qu’est-ce qui prouve ce que j’ai vraiment appris ?" },
            new DialogueLine { text = "Elle cherche à comprendre comment ses acquis sont officiellement validés.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse donne du sens à cette reconnaissance ?",
                isChoice = true,
                choiceA = "On n’a pas besoin de document formel, c’est plutôt entre toi et moi.",
                choiceB = "Ton bulletin et ton diplôme sont des preuves formelles de ce que tu as démontré.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des compétences";
    public int GetAttribute() => 2;
}
