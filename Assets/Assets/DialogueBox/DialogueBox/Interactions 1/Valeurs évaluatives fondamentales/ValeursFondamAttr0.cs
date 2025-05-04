using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr0_RespectIntegriteTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Imane : Tu sais, parfois j’ai l’impression qu’on est juste des chiffres pour certains profs." },
            new DialogueLine { text = "Elle cherche à être reconnue, pas réduite à une note.", isThought = true },
            new DialogueLine {
                text = "Comment lui montrez-vous qu’elle est entendue ?",
                isChoice = true,
                choiceA = "Tu es bien plus que ça. L’évaluation devrait refléter qui tu es, pas seulement un résultat.",
                choiceB = "Les notes sont là pour classer, on ne peut pas y mettre d’émotion.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives fondamentales";
    public int GetAttribute() => 0;
}
