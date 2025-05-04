using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr0_CriteresPrealablesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Yasmine : Est-ce que je vais être notée selon ce que tu trouves bon, ou y’a une grille ?" },
            new DialogueLine { text = "Elle a raison de se questionner : l’évaluation ne devrait pas dépendre de mon humeur.", isThought = true },
            new DialogueLine {
                text = "Quelle explication donnez-vous ?",
                isChoice = true,
                choiceA = "On a défini des critères à l’avance pour évaluer ton travail.",
                choiceB = "Je décide au moment de la correction selon la qualité générale.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interprétation critériée";
    public int GetAttribute() => 0;
}
