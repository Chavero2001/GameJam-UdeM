using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr2_LogiqueAccompagnementTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Hélio : On dirait que tu m’aides à chaque étape... c’est pas juste pour l’examen ?" },
            new DialogueLine { text = "Il commence à percevoir l’approche accompagnante… mais doute encore.", isThought = true },
            new DialogueLine {
                text = "Quelle posture soutient vraiment cette démarche ?",
                isChoice = true,
                choiceA = "C’est à toi de t’organiser. Mon rôle, c’est d’évaluer ton autonomie finale.",
                choiceB = "Non, je suis là pour t’aider à avancer, pas seulement pour te juger à la fin.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide à l’apprentissage";
    public int GetAttribute() => 2;
}
