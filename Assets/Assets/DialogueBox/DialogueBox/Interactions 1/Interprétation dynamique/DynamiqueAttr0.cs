using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr0_ProgressionTempsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Amara : J’étais nulle au début... mais là, j’ai compris. Est-ce que ça compte ?" },
            new DialogueLine { text = "Elle veut savoir si ses efforts dans le temps sont reconnus.", isThought = true },
            new DialogueLine {
                text = "Comment répondez-vous ?",
                isChoice = true,
                choiceA = "Bien sûr. C’est ta progression depuis le départ qui m’intéresse ici.",
                choiceB = "Non, on regarde seulement le résultat final, pas l’évolution.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation dynamique";
    public int GetAttribute() => 0;
}
