using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr2_DocumentsOfficielsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Mateo : Où est-ce que je peux voir les règles exactes pour les examens ?" },
            new DialogueLine { text = "Il cherche un appui officiel. Il a raison de vouloir s’y référer.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse est la plus appropriée ?",
                isChoice = true,
                choiceA = "Elles ne sont pas écrites, c’est selon ce que chaque prof applique.",
                choiceB = "Elles figurent dans des documents officiels comme le régime pédagogique ou ton plan d’intervention.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalités";
    public int GetAttribute() => 2;
}
