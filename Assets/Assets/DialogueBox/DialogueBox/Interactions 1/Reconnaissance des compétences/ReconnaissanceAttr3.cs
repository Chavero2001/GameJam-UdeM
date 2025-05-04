using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr3_ObjectifCertificatifTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Nathan : C�est pour une note... ou c�est pour savoir si je passe ?" },
            new DialogueLine { text = "Il fait la diff�rence entre �valuer pour apprendre et �valuer pour certifier.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse l�aide � bien situer ce moment ?",
                isChoice = true,
                choiceA = "On utilise cette t�che pour voir o� tu en es, sans impact sur ton cheminement.",
                choiceB = "Ici, on vise � valider formellement si tu ma�trises la comp�tence attendue.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des comp�tences";
    public int GetAttribute() => 3;
}
