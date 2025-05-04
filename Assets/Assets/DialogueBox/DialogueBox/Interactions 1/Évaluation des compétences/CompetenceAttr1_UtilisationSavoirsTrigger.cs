using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr1_UtilisationSavoirsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : J�ai bien r�cit� toutes les �tapes ! �a veut dire que je suis comp�tent ?" },
            new DialogueLine { text = "Savoir les �tapes, c�est bien� mais les appliquer, c�est mieux.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse donnez-vous ?",
                isChoice = true,
                choiceA = "Tu as bien retenu, mais j�aimerais voir comment tu les appliques dans une vraie situation.",
                choiceB = "Oui, si tu peux tout r�citer, c�est que tu ma�trises d�j�.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation des comp�tences";
    public int GetAttribute() => 1;
}
