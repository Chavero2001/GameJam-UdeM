using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr1_EvolutionEnseignementTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Noah : Est-ce que tu prends en compte tout ce qu’on a fait, ou juste la dernière évaluation ?" },
            new DialogueLine { text = "Il évoque une vision dynamique… mais est-ce que je l’applique ?", isThought = true },
            new DialogueLine {
                text = "Quelle réponse montre une valeur instrumentale ?",
                isChoice = true,
                choiceA = "Je regarde la tâche finale uniquement. Les précédentes servaient à te préparer.",
                choiceB = "Non, je m’appuie aussi sur les traces d’évolution que j’ai observées depuis le début.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives instrumentales";
    public int GetAttribute() => 1;
}
