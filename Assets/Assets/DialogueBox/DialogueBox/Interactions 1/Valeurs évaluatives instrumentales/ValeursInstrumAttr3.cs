using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr3_OrientationPratiquesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Dounia : C�est dr�le, on fait beaucoup d�exercices qui ressemblent � ceux de l��valuation�" },
            new DialogueLine { text = "Elle observe un lien... entre ce qu�on enseigne et ce qu�on �value. Ce n�est pas un hasard.", isThought = true },
            new DialogueLine {
                text = "Quelle r�flexion soutient une valeur instrumentale ?",
                isChoice = true,
                choiceA = "C�est vrai, mais �a n�a pas �t� intentionnel. L��valuation est ind�pendante de l�enseignement.",
                choiceB = "Oui, c�est fait pour t�aider � cibler les apprentissages importants et aligner nos pratiques.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives instrumentales";
    public int GetAttribute() => 3;
}
