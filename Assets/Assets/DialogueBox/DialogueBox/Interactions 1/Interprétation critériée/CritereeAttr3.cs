using UnityEngine;
using System.Collections.Generic;

public class CritereeAttr3_EquiteAttentesClairesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Zora : C�est pas tr�s clair... Comment savoir si j�ai bien fait ?" },
            new DialogueLine { text = "Elle a besoin de rep�res pour se situer. L��quit� passe par des attentes explicites.", isThought = true },
            new DialogueLine {
                text = "Comment la rassurez-vous ?",
                isChoice = true,
                choiceA = "Les crit�res sont affich�s d�s le d�but, pour que tout le monde sache ce qu�on attend.",
                choiceB = "Tu verras apr�s la correction si tu as compris ou non.",
                isChoiceACorrect = true // Correct is A
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Interpr�tation crit�ri�e";
    public int GetAttribute() => 3;
}
