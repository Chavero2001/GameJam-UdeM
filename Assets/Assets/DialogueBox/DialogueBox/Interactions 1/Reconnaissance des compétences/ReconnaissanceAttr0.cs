using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr0_SavoirFaireContexteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Imran : J�ai r�ussi dans ce projet parce que c��tait concret. Mais dans l�examen �crit, c�est plus flou." },
            new DialogueLine { text = "Il met en �vidence que les contextes influencent ce qu�il peut d�montrer.", isThought = true },
            new DialogueLine {
                text = "Comment lui r�pondez-vous ?",
                isChoice = true,
                choiceA = "Oui, on reconna�t tes comp�tences � partir de ce que tu arrives � faire dans des situations authentiques.",
                choiceB = "Ce qui compte, c�est ta moyenne globale, pas le type de contexte.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des comp�tences";
    public int GetAttribute() => 0;
}
