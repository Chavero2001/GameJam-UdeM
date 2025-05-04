using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr0_Vis�eFormativeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Samira : Tu vas me donner une note pour cet exercice ?" },
            new DialogueLine { text = "Elle n�a pas encore compris l�objectif de cette �tape d��valuation.", isThought = true },
            new DialogueLine {
                text = "Comment clarifiez-vous votre intention ?",
                isChoice = true,
                choiceA = "Non, cette activit� est l� pour t�aider � apprendre, pas pour juger ton niveau.",
                choiceB = "Oui, c�est important de noter tout ce que tu fais, m�me en cours d�apprentissage.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide � l�apprentissage";
    public int GetAttribute() => 0;
}
