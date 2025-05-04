using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr3_UniformitéSouplesseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Anika : Ma sœur est dans une autre école… ils font les choses très différemment là-bas." },
            new DialogueLine { text = "Une question fréquente : uniformité ou autonomie ?", isThought = true },
            new DialogueLine {
                text = "Quelle réponse reflète le cadre réel ?",
                isChoice = true,
                choiceA = "Il y a un cadre commun, mais chaque milieu peut l’adapter selon son contexte.",
                choiceB = "Chaque école invente ses propres règles sans lien avec les autres.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalités";
    public int GetAttribute() => 3;
}
