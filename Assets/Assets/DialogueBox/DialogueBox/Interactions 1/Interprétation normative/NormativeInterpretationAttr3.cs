using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr3_ContextesSelectifsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Nour : Pour entrer en sciences, ils prennent que les meilleurs. C�est pas une �valuation normale, hein ?" },
            new DialogueLine { text = "Elle fait le lien entre �valuation et s�lection, ce qui est tr�s typique dans ce genre de contexte.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse �claire le mieux la situation ?",
                isChoice = true,
                choiceA = "Non, c�est une �valuation formative pour t�aider � progresser.",
                choiceB = "Oui, ici on utilise une m�thode qui classe les �l�ves pour s�lectionner les plus performants.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation normative";
    public int GetAttribute() => 3;
}
