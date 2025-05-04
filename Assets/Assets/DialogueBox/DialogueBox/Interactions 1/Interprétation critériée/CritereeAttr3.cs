using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr3_EquiteAttentesClairesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Zora : C’est pas très clair... Comment savoir si j’ai bien fait ?" },
            new DialogueLine { text = "Elle a besoin de repères pour se situer. L’équité passe par des attentes explicites.", isThought = true },
            new DialogueLine {
                text = "Comment la rassurez-vous ?",
                isChoice = true,
                choiceA = "Les critères sont affichés dès le début, pour que tout le monde sache ce qu’on attend.",
                choiceB = "Tu verras après la correction si tu as compris ou non.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation critériée";
    public int GetAttribute() => 3;
}
