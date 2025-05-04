using UnityEngine;
using System.Collections.Generic;

public class CorrigeAttr2_TachesSimplesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Max : J�ai fait un corrig� pour l�analyse litt�raire... mais y�a tellement de bonnes r�ponses possibles !" },
            new DialogueLine { text = "Hmm� peut-�tre que ce n��tait pas le bon type de t�che pour un corrig� unique.", isThought = true },
            new DialogueLine {
                text = "Que lui sugg�rez-vous ?",
                isChoice = true,
                choiceA = "Le corrig� fonctionne mieux avec des questions ferm�es, � r�ponse unique.",
                choiceB = "Un corrig� peut s�appliquer � toutes les t�ches, m�me tr�s ouvertes.",
                isChoiceACorrect = true // Correct answer is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Corrig�";
    public int GetAttribute() => 2;
}
