using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr1_PositionClasseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Alicia : On m’a dit que j’étais dans la moyenne… mais je sais pas ce que ça veut dire exactement." },
            new DialogueLine { text = "Elle a reçu un jugement relatif, mais elle ne saisit pas encore l’échelle implicite.", isThought = true },
            new DialogueLine {
                text = "Comment l’aidez-vous à décoder ce type de retour ?",
                isChoice = true,
                choiceA = "Ça veut dire que tu as tout compris parfaitement, comme la majorité des élèves.",
                choiceB = "C’est une indication de ta position générale dans le groupe, pas un jugement absolu.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation normative";
    public int GetAttribute() => 1;
}
