using UnityEngine;
using System.Collections.Generic;

public class ValeursInstrumAttr0_DecisionAdaptationTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Zahra : J’ai remarqué que la moitié du groupe a mal réussi la tâche. Tu vas leur donner une autre chance ?" },
            new DialogueLine { text = "Est-ce que j’utilise les résultats pour ajuster ma pédagogie ?", isThought = true },
            new DialogueLine {
                text = "Quelle serait une réponse professionnelle ?",
                isChoice = true,
                choiceA = "Oui, ces résultats me servent à voir ce que je dois reprendre ou réexpliquer.",
                choiceB = "Non, ce qui est fait est fait. Le but, c’était l’évaluation, pas l’adaptation.",
                isChoiceACorrect = true
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs évaluatives instrumentales";
    public int GetAttribute() => 0;
}
