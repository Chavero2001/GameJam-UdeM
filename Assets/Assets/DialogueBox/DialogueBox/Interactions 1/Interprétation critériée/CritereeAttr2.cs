using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr2_MemeCiblePourTousTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Mei : J�ai pas besoin d��tre meilleure que Zora, juste atteindre ce que tu demandes ?" },
            new DialogueLine { text = "Oui, l�objectif est clair pour tout le monde, peu importe les autres.", isThought = true },
            new DialogueLine {
                text = "Quelle clarification donnez-vous ?",
                isChoice = true,
                choiceA = "Tout le monde vise les m�mes crit�res, on ne vous compare pas entre vous.",
                choiceB = "On regarde qui a les meilleures r�ponses, c�est plus juste comme �a.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation crit�ri�e";
    public int GetAttribute() => 2;
}
