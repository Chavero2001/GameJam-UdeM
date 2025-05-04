using UnityEngine;
using System.Collections.Generic;

public class NormativeInterpretationAttr3_ContextesSelectifsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Nour : Pour entrer en sciences, ils prennent que les meilleurs. C’est pas une évaluation normale, hein ?" },
            new DialogueLine { text = "Elle fait le lien entre évaluation et sélection, ce qui est très typique dans ce genre de contexte.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse éclaire le mieux la situation ?",
                isChoice = true,
                choiceA = "Non, c’est une évaluation formative pour t’aider à progresser.",
                choiceB = "Oui, ici on utilise une méthode qui classe les élèves pour sélectionner les plus performants.",
                isChoiceACorrect = false // Correct is now B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation normative";
    public int GetAttribute() => 3;
}
