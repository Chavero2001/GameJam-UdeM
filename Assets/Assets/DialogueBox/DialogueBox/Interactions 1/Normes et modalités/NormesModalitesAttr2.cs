using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr2_DocumentsOfficielsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Mateo : O� est-ce que je peux voir les r�gles exactes pour les examens ?" },
            new DialogueLine { text = "Il cherche un appui officiel. Il a raison de vouloir s�y r�f�rer.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse est la plus appropri�e ?",
                isChoice = true,
                choiceA = "Elles ne sont pas �crites, c�est selon ce que chaque prof applique.",
                choiceB = "Elles figurent dans des documents officiels comme le r�gime p�dagogique ou ton plan d�intervention.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalit�s";
    public int GetAttribute() => 2;
}
