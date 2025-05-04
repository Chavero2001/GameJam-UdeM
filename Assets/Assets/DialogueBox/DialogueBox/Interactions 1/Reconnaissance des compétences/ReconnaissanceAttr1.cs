using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr1_CertifieAcquisTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Lina : Donc m�me si j�ai 60 %, �a peut montrer que j�ai vraiment acquis quelque chose ?" },
            new DialogueLine { text = "Elle comprend que la note n�est pas l�unique indicateur.", isThought = true },
            new DialogueLine {
                text = "Quelle clarification donnez-vous ?",
                isChoice = true,
                choiceA = "La note est l�unique preuve que tu as r�ussi.",
                choiceB = "C�est aussi ton autonomie, ton application concr�te, qui montrent ce que tu as vraiment acquis.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des comp�tences";
    public int GetAttribute() => 1;
}
