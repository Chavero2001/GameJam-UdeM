using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr1_CertifieAcquisTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Lina : Donc même si j’ai 60 %, ça peut montrer que j’ai vraiment acquis quelque chose ?" },
            new DialogueLine { text = "Elle comprend que la note n’est pas l’unique indicateur.", isThought = true },
            new DialogueLine {
                text = "Quelle clarification donnez-vous ?",
                isChoice = true,
                choiceA = "La note est l’unique preuve que tu as réussi.",
                choiceB = "C’est aussi ton autonomie, ton application concrète, qui montrent ce que tu as vraiment acquis.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des compétences";
    public int GetAttribute() => 1;
}
