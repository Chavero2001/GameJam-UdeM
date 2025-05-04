using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr1_JusticeEquiteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Andrei : Est-ce que c�est juste si on a tous exactement la m�me t�che, m�me si certains ont plus de difficult�s ?" },
            new DialogueLine { text = "Sa question soul�ve l�enjeu d��quit� ce n�est pas la m�me chose que l��galit�.", isThought = true },
            new DialogueLine {
                text = "Comment r�agissez-vous ?",
                isChoice = true,
                choiceA = "Oui, on donne la m�me chose � tout le monde pour �tre �quitable.",
                choiceB = "L��quit�, c�est offrir � chacun ce dont il a besoin pour r�ussir.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives fondamentales";
    public int GetAttribute() => 1;
}
