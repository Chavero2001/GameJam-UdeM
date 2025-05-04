using UnityEngine;
using System.Collections.Generic;

public class DemarcheAttr4_RigueurTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : Est-ce que je peux juste �crire � Beau travail ! � sur toutes les copies ?" },
            new DialogueLine { text = "Ce n�est pas vraiment rigoureux� ni tr�s professionnel.", isThought = true },
            new DialogueLine {
                text = "Comment r�agissez-vous ?",
                isChoice = true,
                choiceA = "Utilise des crit�res structur�s pour rendre ton jugement rigoureux.",
                choiceB = "Oui, tant que tu le sens bien, �a passe.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        // Register this interaction for tracking
        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "D�marche �valuative";
    public int GetAttribute() => 4;
}
