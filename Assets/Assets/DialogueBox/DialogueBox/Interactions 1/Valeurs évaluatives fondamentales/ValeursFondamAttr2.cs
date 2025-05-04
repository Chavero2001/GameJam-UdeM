using UnityEngine;
using System.Collections.Generic;

public class ValeursFondamAttr2_Coh�renceEthiqueTrigger : MonoBehaviour, IInteractionTrigger
{
    public DialogueBoxLegacy dialogueBox;

    public void TriggerDialogue()
    {
        var lines = new List<DialogueLine>()
        {
            new DialogueLine { text = "Fatima : Mais comment t�as d�termin� ma note ? On n�avait pas eu les crit�res avant�" },
            new DialogueLine { text = "Elle pointe un manque de transparence. Ai-je agi de fa�on coh�rente ?", isThought = true },
            new DialogueLine {
                text = "Quelle r�ponse reconna�t l�enjeu ?",
                isChoice = true,
                choiceA = "Je note selon ce que je vois, m�me si ce n��tait pas annonc� clairement.",
                choiceB = "Tu as raison, les crit�res auraient d� �tre clairs d�s le d�part.",
                isChoiceACorrect = false
            }
        };

        dialogueBox.StartDialogue(lines);

        ProgressManager.Instance.SetCurrentAttribute(
            GetConcept(), GetAttribute()
        );
    }

    public string GetConcept() => "Valeurs �valuatives fondamentales";
    public int GetAttribute() => 2;
}
