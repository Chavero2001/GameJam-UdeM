using UnityEngine;
using System.Collections.Generic;

public class NormativeAttr3_ExamenStandardiseTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Finley : L�examen du minist�re, c�est pareil que ce qu�on fait en classe ?" },
            new DialogueLine { text = "Pas tout � fait� il y a une logique de comparaison derri�re.", isThought = true },
            new DialogueLine {
                text = "Comment expliquez-vous la diff�rence ?",
                isChoice = true,
                choiceA = "Les examens standardis�s sont con�us pour comparer les r�sultats entre �l�ves � grande �chelle.",
                choiceB = "Ils servent surtout � voir si chacun a fait des progr�s personnels.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "�valuation normative";
    public int GetAttribute() => 2;
}
