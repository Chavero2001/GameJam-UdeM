using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class InteractionManager : MonoBehaviour
{
    public DialogueBoxLegacy dialogueBox;
    public TransitionController transition;
    public List<MonoBehaviour> allTriggers; // List of interaction trigger scripts
    private int currentIndex = -1;

    private bool interactionInProgress = false;

    private void Start()
    {
        StartCoroutine(BeginNextInteraction());
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public IEnumerator BeginNextInteraction()
    {
        interactionInProgress = true;

        yield return transition.FadeOut();
        yield return new WaitForSeconds(0.3f);

        // 🧠 Filter out solved interactions
        List<IInteractionTrigger> unsolvedTriggers = new List<IInteractionTrigger>();
        foreach (var triggerMono in allTriggers)
        {
            if (triggerMono is IInteractionTrigger trigger)
            {
                string concept = trigger.GetConcept();
                int attribute = trigger.GetAttribute();

                if (!ProgressManager.Instance.IsAttributeSolved(concept, attribute))
                    unsolvedTriggers.Add(trigger);
            }
        }

        Debug.Log($"[INTERACTION MANAGER] Unsolved triggers available: {unsolvedTriggers.Count}");

        foreach (var t in unsolvedTriggers)
        {
            Debug.Log($"[UNSOLVED] {t.GetConcept()} — {t.GetAttribute()}");
        }


        if (unsolvedTriggers.Count == 0)
        {
            SceneManager.LoadScene(2);
            Debug.Log("✅ All interactions completed!");
            // TODO: trigger end screen, score summary, etc.
            yield break;
        }

        // 🎲 Choose a random unsolved trigger
        int randomIndex = Random.Range(0, unsolvedTriggers.Count);
        IInteractionTrigger selected = unsolvedTriggers[randomIndex];
        Debug.Log($"[CHOSEN] {selected.GetConcept()} — {selected.GetAttribute()}");

        selected.TriggerDialogue();

        yield return transition.FadeIn();
        interactionInProgress = false;
    }

    // Called by DialogueBox when the interaction ends
    public void OnDialogueComplete()
    {
        if (!interactionInProgress)
        {
            Invoke("wait", 1);
            
        }
    }
    void wait()
    {
        StartCoroutine(BeginNextInteraction());
    }
}
