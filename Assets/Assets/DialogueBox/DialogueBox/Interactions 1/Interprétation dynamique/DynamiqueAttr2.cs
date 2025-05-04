using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr2_RetroactionIndivTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Sabrine : J�aimerais savoir ce que je pourrais faire pour m�am�liorer, pas juste la note." },
            new DialogueLine { text = "Elle attend plus qu�une �tiquette. Elle veut un retour utile, pour elle sp�cifiquement.", isThought = true },
            new DialogueLine {
                text = "Quelle approche adoptez-vous ?",
                isChoice = true,
                choiceA = "La note suffit � montrer o� tu te situes dans la classe.",
                choiceB = "D�accord, je vais te donner une r�troaction personnalis�e sur ton travail.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation dynamique";
    public int GetAttribute() => 2;
}
