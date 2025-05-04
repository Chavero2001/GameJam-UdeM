using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr0_ModeleReponseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Élise : J’ai corrigé les copies... un peu au feeling, tu sais ?" },
            new DialogueLine { text = "Elle n’a même pas regardé le corrigé…", isThought = true },
            new DialogueLine {
                text = "Comment réagissez-vous ?",
                isChoice = true,
                choiceA = "C’est bien si tu y vas à l’instinct. Tu connais les bonnes réponses, non ?",
                choiceB = "Il vaut mieux te baser sur le corrigé prévu pour assurer l’équité.",
                isChoiceACorrect = false // Correct answer is B
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrigé";
    public int GetAttribute() => 0;
}
