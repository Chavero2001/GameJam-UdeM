using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr2_EcartsPercentilesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Tenzin : Dans le rapport, ils disent que je suis au 85e percentile... Ça veut dire quoi ?" },
            new DialogueLine { text = "Il a reçu un score normatif, mais sans contexte, c’est flou pour lui.", isThought = true },
            new DialogueLine {
                text = "Quelle explication est la plus utile ?",
                isChoice = true,
                choiceA = "C’est un critère spécifique que tu devais atteindre pour réussir.",
                choiceB = "Ça indique que tu te situes au-dessus de la majorité des élèves évalués.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation normative";
    public int GetAttribute() => 2;
}
