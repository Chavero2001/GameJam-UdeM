using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr1_BonnesEtapesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : Je savais pas qu�il fallait �crire les �tapes... j�ai juste mis le r�sultat." },
            new DialogueLine { text = "Le corrig� indiquait clairement les �tapes attendues.", isThought = true },
            new DialogueLine {
                text = "Comment l�aidez-vous � comprendre ?",
                isChoice = true,
                choiceA = "C�est le r�sultat qui compte, pas besoin d��crire toutes les �tapes.",
                choiceB = "Les �tapes font partie de la r�ponse attendue. Elles sont dans le corrig�.",
                isChoiceACorrect = false // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrig�";
    public int GetAttribute() => 1;
}
