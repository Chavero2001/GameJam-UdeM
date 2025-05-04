using UnityEngine;
using System.Collections.Generic;

public class CompetenceAttr1_UtilisationSavoirsTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : J’ai bien récité toutes les étapes ! Ça veut dire que je suis compétent ?" },
            new DialogueLine { text = "Savoir les étapes, c’est bien… mais les appliquer, c’est mieux.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse donnez-vous ?",
                isChoice = true,
                choiceA = "Tu as bien retenu, mais j’aimerais voir comment tu les appliques dans une vraie situation.",
                choiceB = "Oui, si tu peux tout réciter, c’est que tu maîtrises déjà.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Évaluation des compétences";
    public int GetAttribute() => 1;
}
