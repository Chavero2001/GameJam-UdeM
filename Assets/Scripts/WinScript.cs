using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Text skill1; // Assign your win UI (e.g. a panel or message) in the Inspector
    private bool hasWon = false;
    void Start()
    {
    }
        void Update()
    {
        if (hasWon) return; // Stop checking if already won
        if(skill1.text != "DÉMARCHE ÉVALUATIVE")
        {
            return;
        }
        // All texts are "1" — player wins!
        hasWon = true;
        Debug.Log("You win!");
    }
}
