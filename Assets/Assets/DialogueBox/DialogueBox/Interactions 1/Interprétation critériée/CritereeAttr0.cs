using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr0_CriteresPrealablesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Yasmine : Est-ce que je vais �tre not�e selon ce que tu trouves bon, ou y�a une grille ?" },
            new DialogueLine { text = "Elle a raison de se questionner : l��valuation ne devrait pas d�pendre de mon humeur.", isThought = true },
            new DialogueLine {
                text = "Quelle explication donnez-vous ?",
                isChoice = true,
                choiceA = "On a d�fini des crit�res � l�avance pour �valuer ton travail.",
                choiceB = "Je d�cide au moment de la correction selon la qualit� g�n�rale.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation crit�ri�e";
    public int GetAttribute() => 0;
}
