using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr3_EvaluerCompetencesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : J’imagine que c’est pas juste un exercice... c’est pour voir ce qu’on sait vraiment faire ?" },
            new DialogueLine { text = "Exactement. Cette tâche sert à évaluer la compétence globale.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse appuyez-vous ?",
                isChoice = true,
                choiceA = "Oui, cette tâche sert à vérifier si tu maîtrises une compétence dans son ensemble.",
                choiceB = "Pas forcément. C’est juste une autre activité sans objectif précis.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche complexe";
    public int GetAttribute() => 3;
}
