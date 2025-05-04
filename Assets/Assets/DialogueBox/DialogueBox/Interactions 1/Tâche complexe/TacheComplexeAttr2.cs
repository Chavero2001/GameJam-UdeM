using UnityEngine;
using System.Collections.Generic;

public class TacheComplexeAttr2_ReponsesMultiplesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : J’ai pas la même réponse que Max, mais on a tous les deux eu des bons points ?" },
            new DialogueLine { text = "Ils ont emprunté deux chemins valables vers la solution.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous cela ?",
                isChoice = true,
                choiceA = "Oui, plusieurs démarches peuvent mener à un résultat pertinent.",
                choiceB = "Non, une seule méthode était attendue, mais on a été indulgents.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Tâche complexe";
    public int GetAttribute() => 2;
}
