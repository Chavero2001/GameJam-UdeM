using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr1_PositionClasseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Alicia : On m�a dit que j��tais dans la moyenne� mais je sais pas ce que �a veut dire exactement." },
            new DialogueLine { text = "Elle a re�u un jugement relatif, mais elle ne saisit pas encore l��chelle implicite.", isThought = true },
            new DialogueLine {
                text = "Comment l�aidez-vous � d�coder ce type de retour ?",
                isChoice = true,
                choiceA = "�a veut dire que tu as tout compris parfaitement, comme la majorit� des �l�ves.",
                choiceB = "C�est une indication de ta position g�n�rale dans le groupe, pas un jugement absolu.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation normative";
    public int GetAttribute() => 1;
}
