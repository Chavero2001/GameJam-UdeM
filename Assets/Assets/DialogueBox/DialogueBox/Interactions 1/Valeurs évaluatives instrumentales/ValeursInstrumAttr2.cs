using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr2_CritèresExactitudeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Thiago : Comment tu sais que ce que j’ai fait vaut 70 % ? C’est un peu flou..." },
            new DialogueLine { text = "Une remarque légitime… est-ce que j’ai bien cadré l’évaluation ?", isThought = true },
            new DialogueLine {
                text = "Que répondez-vous ?",
                isChoice = true,
                choiceA = "J’évalue en fonction de mon impression générale de ton travail.",
                choiceB = "Je me base sur les critères définis dans la grille, ce qui rend la note explicable.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives instrumentales";
    public int GetAttribute() => 2;
}
