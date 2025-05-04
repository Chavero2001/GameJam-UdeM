using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr3_OrientationPratiquesTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Dounia : C’est drôle, on fait beaucoup d’exercices qui ressemblent à ceux de l’évaluation…" },
            new DialogueLine { text = "Elle observe un lien... entre ce qu’on enseigne et ce qu’on évalue. Ce n’est pas un hasard.", isThought = true },
            new DialogueLine {
                text = "Quelle réflexion soutient une valeur instrumentale ?",
                isChoice = true,
                choiceA = "C’est vrai, mais ça n’a pas été intentionnel. L’évaluation est indépendante de l’enseignement.",
                choiceB = "Oui, c’est fait pour t’aider à cibler les apprentissages importants et aligner nos pratiques.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives instrumentales";
    public int GetAttribute() => 3;
}
