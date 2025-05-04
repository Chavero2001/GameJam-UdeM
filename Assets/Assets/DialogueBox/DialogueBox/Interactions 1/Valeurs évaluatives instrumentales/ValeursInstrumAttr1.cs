using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr1_EvolutionEnseignementTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Noah : Est-ce que tu prends en compte tout ce qu�on a fait, ou juste la derni�re �valuation ?" },
            new DialogueLine { text = "Il �voque une vision dynamique� mais est-ce que je l�applique ?", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse montre une valeur instrumentale ?",
                isChoice = true,
                choiceA = "Je regarde la t�che finale uniquement. Les pr�c�dentes servaient � te pr�parer.",
                choiceB = "Non, je m�appuie aussi sur les traces d��volution que j�ai observ�es depuis le d�but.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives instrumentales";
    public int GetAttribute() => 1;
}
