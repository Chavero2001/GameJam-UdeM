using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr3_Uniformit�SouplesseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Anika : Ma s�ur est dans une autre �cole� ils font les choses tr�s diff�remment l�-bas." },
            new DialogueLine { text = "Une question fr�quente : uniformit� ou autonomie ?", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse refl�te le cadre r�el ?",
                isChoice = true,
                choiceA = "Il y a un cadre commun, mais chaque milieu peut l�adapter selon son contexte.",
                choiceB = "Chaque �cole invente ses propres r�gles sans lien avec les autres.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalit�s";
    public int GetAttribute() => 3;
}
