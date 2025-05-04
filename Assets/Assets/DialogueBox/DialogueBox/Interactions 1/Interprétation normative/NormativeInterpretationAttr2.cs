using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr2_EcartsPercentilesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Tenzin : Dans le rapport, ils disent que je suis au 85e percentile... �a veut dire quoi ?" },
            new DialogueLine { text = "Il a re�u un score normatif, mais sans contexte, c�est flou pour lui.", isThought = true },
            new DialogueLine {
                text = "Quelle explication est la plus utile ?",
                isChoice = true,
                choiceA = "C�est un crit�re sp�cifique que tu devais atteindre pour r�ussir.",
                choiceB = "�a indique que tu te situes au-dessus de la majorit� des �l�ves �valu�s.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation normative";
    public int GetAttribute() => 2;
}
