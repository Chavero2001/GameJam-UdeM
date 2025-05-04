using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr2_CohérenceEthiqueTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Fatima : Mais comment t’as déterminé ma note ? On n’avait pas eu les critères avant…" },
            new DialogueLine { text = "Elle pointe un manque de transparence. Ai-je agi de façon cohérente ?", isThought = true },
            new DialogueLine {
                text = "Quelle réponse reconnaît l’enjeu ?",
                isChoice = true,
                choiceA = "Je note selon ce que je vois, même si ce n’était pas annoncé clairement.",
                choiceB = "Tu as raison, les critères auraient dû être clairs dès le départ.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives fondamentales";
    public int GetAttribute() => 2;
}
