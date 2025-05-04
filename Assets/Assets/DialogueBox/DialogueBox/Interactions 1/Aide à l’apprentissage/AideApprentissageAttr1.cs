using UnityEngine;
using System.Collections.Generic;

public class AideApprentissageAttr1_RetroactionUtileTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Tariq : Tu vas juste me dire combien j�ai eu... ou tu m�expliques ce que j�ai rat� ?" },
            new DialogueLine { text = "Il a besoin d�un retour qui l�aide � avancer, pas seulement d�un verdict.", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse r�pond vraiment � son besoin ?",
                isChoice = true,
                choiceA = "La note suffit, elle montre ton niveau actuel.",
                choiceB = "Je vais t�indiquer ce qui fonctionne bien et ce que tu pourrais retravailler.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Aide � l�apprentissage";
    public int GetAttribute() => 1;
}
