using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr2_Crit�resExactitudeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Thiago : Comment tu sais que ce que j�ai fait vaut 70 % ? C�est un peu flou..." },
            new DialogueLine { text = "Une remarque l�gitime� est-ce que j�ai bien cadr� l��valuation ?", isThought = true },
            new DialogueLine {
                text = "Que r�pondez-vous ?",
                isChoice = true,
                choiceA = "J��value en fonction de mon impression g�n�rale de ton travail.",
                choiceB = "Je me base sur les crit�res d�finis dans la grille, ce qui rend la note explicable.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives instrumentales";
    public int GetAttribute() => 2;
}
