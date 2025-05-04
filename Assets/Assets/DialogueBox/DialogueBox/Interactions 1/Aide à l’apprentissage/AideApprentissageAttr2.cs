using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr2_LogiqueAccompagnementTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "H�lio : On dirait que tu m�aides � chaque �tape... c�est pas juste pour l�examen ?" },
            new DialogueLine { text = "Il commence � percevoir l�approche accompagnante� mais doute encore.", isThought = true },
            new DialogueLine {
                text = "Quelle posture soutient vraiment cette d�marche ?",
                isChoice = true,
                choiceA = "C�est � toi de t�organiser. Mon r�le, c�est d��valuer ton autonomie finale.",
                choiceB = "Non, je suis l� pour t�aider � avancer, pas seulement pour te juger � la fin.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide � l�apprentissage";
    public int GetAttribute() => 2;
}
