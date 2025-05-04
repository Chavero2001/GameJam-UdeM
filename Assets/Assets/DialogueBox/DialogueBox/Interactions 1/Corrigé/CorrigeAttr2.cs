using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr2_TachesSimplesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : J’ai fait un corrigé pour l’analyse littéraire... mais y’a tellement de bonnes réponses possibles !" },
            new DialogueLine { text = "Hmm… peut-être que ce n’était pas le bon type de tâche pour un corrigé unique.", isThought = true },
            new DialogueLine {
                text = "Que lui suggérez-vous ?",
                isChoice = true,
                choiceA = "Le corrigé fonctionne mieux avec des questions fermées, à réponse unique.",
                choiceB = "Un corrigé peut s’appliquer à toutes les tâches, même très ouvertes.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrigé";
    public int GetAttribute() => 2;
}
