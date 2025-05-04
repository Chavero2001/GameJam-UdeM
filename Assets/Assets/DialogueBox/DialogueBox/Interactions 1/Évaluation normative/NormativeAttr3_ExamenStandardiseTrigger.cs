using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr3_ExamenStandardiseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : L’examen du ministère, c’est pareil que ce qu’on fait en classe ?" },
            new DialogueLine { text = "Pas tout à fait… il y a une logique de comparaison derrière.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous la différence ?",
                isChoice = true,
                choiceA = "Les examens standardisés sont conçus pour comparer les résultats entre élèves à grande échelle.",
                choiceB = "Ils servent surtout à voir si chacun a fait des progrès personnels.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation normative";
    public int GetAttribute() => 2;
}
