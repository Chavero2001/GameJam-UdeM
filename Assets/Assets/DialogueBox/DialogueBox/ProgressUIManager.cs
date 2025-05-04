using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ProgressUIManager : MonoBehaviour
{
    public GameObject entryPrefab;           // Prefab with concept name and progress UI
    public Transform contentParent;          // Scroll view content holder

    private Dictionary<string, GameObject> entries = new Dictionary<string, GameObject>();

    private void Start()
    {
        GenerateUI();
    }

    public void GenerateUI()
    {
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        foreach (var kvp in StaticVariableManager.skillValues)
        {
            GameObject entry = Instantiate(entryPrefab, contentParent);
            Text label = entry.GetComponentInChildren<Text>();
            if (label != null)
                label.text = $"{kvp.Key} — {kvp.Value}%";

            entries[kvp.Key] = entry;
        }
    }

    public void RefreshUI()
    {
        foreach (var kvp in StaticVariableManager.skillValues)
        {
            if (entries.TryGetValue(kvp.Key, out GameObject entry))
            {
                Text label = entry.GetComponentInChildren<Text>();
                if (label != null)
                    label.text = $"{kvp.Key} — {kvp.Value}%";
            }
        }
    }
}
