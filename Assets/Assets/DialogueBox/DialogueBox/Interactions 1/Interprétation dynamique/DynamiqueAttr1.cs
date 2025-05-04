using UnityEngine;
using System.Collections.Generic;

public class DynamiqueAttr1_ComparaisonSoiTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Kenji : J’ai pas la même note que Sabrine… pourtant, j’ai fait mieux que la dernière fois !" },
            new DialogueLine { text = "Il évalue son progrès par rapport à lui-même. Et il a raison de le souligner.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse appuie cette vision ?",
                isChoice = true,
                choiceA = "On évalue en fonction du groupe. Ce que les autres font compte aussi.",
                choiceB = "Ce qui compte ici, c’est ta propre évolution, pas ta comparaison avec les autres.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation dynamique";
    public int GetAttribute() => 1;
}
