using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Tracks which attributes the player has solved and manages progress updates per concept.
/// </summary>
public class ProgressManager : MonoBehaviour
{
    public static ProgressManager Instance;

    private Dictionary<string, HashSet<int>> solvedAttributes = new Dictionary<string, HashSet<int>>();
    private string currentConcept;
    private int currentAttribute;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    /// <summary>
    /// Called by each trigger to specify which attribute is being worked on.
    /// </summary>
    public void SetCurrentAttribute(string concept, int attribute)
    {
        currentConcept = concept;
        currentAttribute = attribute;
    }

    /// <summary>
    /// Marks current attribute as solved and updates concept score.
    /// </summary>
    public void MarkCurrentAsSolved()
    {
        if (!string.IsNullOrEmpty(currentConcept))
        {
            if (!solvedAttributes.ContainsKey(currentConcept))
            {
                solvedAttributes[currentConcept] = new HashSet<int>();
            }

            if (!StaticVariableManager.skillValues[currentConcept].flags[currentAttribute])
                {
                solvedAttributes[currentConcept].Add(currentAttribute);
                // ✅ Update external skillValues dictionary
                if (StaticVariableManager.skillValues.ContainsKey(currentConcept))
                {
                    if(currentConcept== "Corrigé" || currentConcept == "Outil de jugement" || currentConcept ==  "Valeurs évaluatives fondamentales")
                    {
                        StaticVariableManager.skillValues[currentConcept].value += 33f;
                    }
                    else
                    {
                        StaticVariableManager.skillValues[currentConcept].value += 25f;
                    }

                    Debug.Log($"🔼 Progress increased: {currentConcept} is now at {StaticVariableManager.skillValues[currentConcept].value}%");
                    Debug.Log(currentAttribute);
                    StaticVariableManager.skillValues[currentConcept].flags[currentAttribute] = true;
                    StaticVariableManager.currentAnimation = Random.Range(1,3);
                }
                else
                {
                    
                    Debug.LogWarning($"❗ Concept key not found in skillValues: {currentConcept}");
                }
            }
            else
            {
                Debug.Log($"🔁 Attribute already solved:  — skipping duplicate score.");
            }
        }
    }

    /// <summary>
    /// Use this if you want to block interactions with already-solved attributes.
    /// </summary>
    public bool IsAttributeSolved(string concept, int attribute)
    {
        return solvedAttributes.ContainsKey(concept) && solvedAttributes[concept].Contains(attribute);
    }
}
