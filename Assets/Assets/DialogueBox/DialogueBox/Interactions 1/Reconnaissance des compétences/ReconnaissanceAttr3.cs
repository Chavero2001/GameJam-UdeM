using UnityEngine;
using System.Collections.Generic;

public class ReconnaissanceAttr3_ObjectifCertificatifTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Nathan : C’est pour une note... ou c’est pour savoir si je passe ?" },
            new DialogueLine { text = "Il fait la différence entre évaluer pour apprendre et évaluer pour certifier.", isThought = true },
            new DialogueLine {
                text = "Quelle réponse l’aide à bien situer ce moment ?",
                isChoice = true,
                choiceA = "On utilise cette tâche pour voir où tu en es, sans impact sur ton cheminement.",
                choiceB = "Ici, on vise à valider formellement si tu maîtrises la compétence attendue.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Reconnaissance des compétences";
    public int GetAttribute() => 3;
}
