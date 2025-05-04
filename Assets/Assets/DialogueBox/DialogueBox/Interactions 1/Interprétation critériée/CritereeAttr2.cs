using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr2_MemeCiblePourTousTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Mei : J’ai pas besoin d’être meilleure que Zora, juste atteindre ce que tu demandes ?" },
            new DialogueLine { text = "Oui, l’objectif est clair pour tout le monde, peu importe les autres.", isThought = true },
            new DialogueLine {
                text = "Quelle clarification donnez-vous ?",
                isChoice = true,
                choiceA = "Tout le monde vise les mêmes critères, on ne vous compare pas entre vous.",
                choiceB = "On regarde qui a les meilleures réponses, c’est plus juste comme ça.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation critériée";
    public int GetAttribute() => 2;
}
