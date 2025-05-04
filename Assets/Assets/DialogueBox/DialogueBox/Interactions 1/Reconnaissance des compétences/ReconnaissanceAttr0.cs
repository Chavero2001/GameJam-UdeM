using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr0_SavoirFaireContexteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Imran : J’ai réussi dans ce projet parce que c’était concret. Mais dans l’examen écrit, c’est plus flou." },
            new DialogueLine { text = "Il met en évidence que les contextes influencent ce qu’il peut démontrer.", isThought = true },
            new DialogueLine {
                text = "Comment lui répondez-vous ?",
                isChoice = true,
                choiceA = "Oui, on reconnaît tes compétences à partir de ce que tu arrives à faire dans des situations authentiques.",
                choiceB = "Ce qui compte, c’est ta moyenne globale, pas le type de contexte.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des compétences";
    public int GetAttribute() => 0;
}
