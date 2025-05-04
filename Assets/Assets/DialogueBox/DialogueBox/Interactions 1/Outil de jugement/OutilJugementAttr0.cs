using UnityEngine;
using System.Collections.Generic;

public class OutilJugementAttr0_CritèresDescripteursTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : On note juste sur 10 ? Genre... au pif ?" },
            new DialogueLine { text = "Non. On a des critères, des niveaux, et des indicateurs bien définis.", isThought = true },
            new DialogueLine {
                text = "Comment précisez-vous le fonctionnement ?",
                isChoice = true,
                choiceA = "On utilise des critères, des descripteurs et une échelle pour évaluer avec précision.",
                choiceB = "On attribue les points selon l’impression générale que ça donne.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Outil de jugement";
    public int GetAttribute() => 0;
}
