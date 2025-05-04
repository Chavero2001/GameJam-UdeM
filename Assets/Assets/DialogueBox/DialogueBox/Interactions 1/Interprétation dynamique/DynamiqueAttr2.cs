using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr2_RetroactionIndivTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Sabrine : J’aimerais savoir ce que je pourrais faire pour m’améliorer, pas juste la note." },
            new DialogueLine { text = "Elle attend plus qu’une étiquette. Elle veut un retour utile, pour elle spécifiquement.", isThought = true },
            new DialogueLine {
                text = "Quelle approche adoptez-vous ?",
                isChoice = true,
                choiceA = "La note suffit à montrer où tu te situes dans la classe.",
                choiceB = "D’accord, je vais te donner une rétroaction personnalisée sur ton travail.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation dynamique";
    public int GetAttribute() => 2;
}
