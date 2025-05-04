using UnityEngine;
using System.Collections.Generic;

public class NormesModalitesAttr0_CadreMinistereTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Bilal : Est-ce que c�est toi qui d�cides des r�gles d��valuation ?" },
            new DialogueLine { text = "Il faut lui expliquer que certaines r�gles me d�passent.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse est la plus juste ?",
                isChoice = true,
                choiceA = "Non, plusieurs r�gles viennent de directives minist�rielles ou de l��cole.",
                choiceB = "Oui, chaque enseignant applique les crit�res comme il veut.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Normes et modalit�s";
    public int GetAttribute() => 0;
}
