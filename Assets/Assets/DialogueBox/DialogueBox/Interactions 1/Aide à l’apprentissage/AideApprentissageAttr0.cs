using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr0_ViséeFormativeTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Samira : Tu vas me donner une note pour cet exercice ?" },
            new DialogueLine { text = "Elle n’a pas encore compris l’objectif de cette étape d’évaluation.", isThought = true },
            new DialogueLine {
                text = "Comment clarifiez-vous votre intention ?",
                isChoice = true,
                choiceA = "Non, cette activité est là pour t’aider à apprendre, pas pour juger ton niveau.",
                choiceB = "Oui, c’est important de noter tout ce que tu fais, même en cours d’apprentissage.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide à l’apprentissage";
    public int GetAttribute() => 0;
}
