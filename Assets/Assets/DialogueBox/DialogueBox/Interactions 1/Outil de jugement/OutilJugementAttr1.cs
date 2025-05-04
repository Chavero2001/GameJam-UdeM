using UnityEngine;
using System.Collections.Generic;

public class OutilJugementAttr1_SoutienJugementTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "�lise : J�h�site... parfois je me fie � mon instinct pour noter." },
            new DialogueLine { text = "Un outil de jugement structur� lui donnerait plus de confiance.", isThought = true },
            new DialogueLine {
                text = "Que lui proposez-vous ?",
                isChoice = true,
                choiceA = "Ton instinct suffit. Tu connais les �l�ves.",
                choiceB = "Utiliser un outil structur� peut appuyer ton jugement de fa�on plus fiable.",
                isChoiceACorrect = true // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Outil de jugement";
    public int GetAttribute() => 1;
}
