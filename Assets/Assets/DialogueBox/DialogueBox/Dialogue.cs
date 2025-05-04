using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages displaying dialogue lines with typing effects, internal thoughts, and choices.
/// </summary>
public class DialogueBoxLegacy : MonoBehaviour
{
    [Header("UI Elements")]
    public Text dialogueText;              // The main dialogue text field
    public GameObject dialogueBoxPanel;    // Panel that contains all dialogue UI

    [Header("Choice Buttons")]
    public GameObject choicePanel;         // Panel containing choice buttons
    public Button choiceButtonA;           // Left button for a choice
    public Button choiceButtonB;           // Right button for a choice
    public Text choiceTextA;               // Text displayed on button A
    public Text choiceTextB;               // Text displayed on button B

    [Header("Dialogue Settings")]
    [TextArea(3, 10)]
    public List<DialogueLine> dialogueLines = new List<DialogueLine>(); // List of structured dialogue lines
    public float typingSpeed = 0.05f;       // Speed of text typing effect

    private int currentLineIndex = 0;       // Current dialogue line index
    private bool isTyping = false;          // Whether the line is currently typing out
    private DialogueLine currentLine;       // Current line being displayed
    public AudioSource good;
    public AudioSource bad;
    private bool end = false;
    private void Start()
    {
        //dialogueBoxPanel.SetActive(false); // Uncomment if you want to hide the box at game start
    }

    /// <summary>
    /// Starts a dialogue sequence from a list of DialogueLine objects.
    /// </summary>
    public void StartDialogue(List<DialogueLine> lines)
    {
        end = false;
        dialogueLines = lines;
        currentLineIndex = 0;
        dialogueBoxPanel.SetActive(true);
        choicePanel.SetActive(false); // Ensure choices are hidden at start
        DisplayNextLine();
    }

    /*
    // Optional helper if you want to start dialogue from string[] instead of DialogueLine[]
    public void StartDialogueFromStrings(string[] lines)
    {
        dialogueLines.Clear();
        foreach (string line in lines)
        {
            dialogueLines.Add(new DialogueLine { text = line });
        }
        StartDialogue(dialogueLines);
    }
    */

    /// <summary>
    /// Displays the next dialogue line, checking if it's a choice or thought.
    /// </summary>
    private void DisplayNextLine()
    {
        // 🛑 Check if all lines have been displayed
        if (currentLineIndex >= dialogueLines.Count)
        {
            Debug.Log("[DIALOGUE] Reached end of dialogue. Calling EndDialogue.");
            EndDialogue();
            return;
        }

        // ✅ Load current line
        currentLine = dialogueLines[currentLineIndex];

        if (currentLine.isChoice)
        {
            // Show choice buttons
            ShowChoices(currentLine);
        }
        else
        {
            // Show dialogue text or thought with typing effect
            string displayText = currentLine.isThought ? $"(Pensée) {currentLine.text}" : currentLine.text;
            StartCoroutine(TypeLine(displayText));
        }
    }


    /// <summary>
    /// Displays choices and sets up button listeners.
    /// </summary>
    private void ShowChoices(DialogueLine line)
    {
        isTyping = false;
        StopAllCoroutines();
        dialogueText.text = line.text;  // Optional: use as a prompt above buttons
        choicePanel.SetActive(true);

        choiceTextA.text = line.choiceA;
        choiceTextB.text = line.choiceB;

        // Remove previous listeners to avoid stacking
        choiceButtonA.onClick.RemoveAllListeners();
        choiceButtonB.onClick.RemoveAllListeners();

        // Setup button click actions
        choiceButtonA.onClick.AddListener(() => OnChoiceSelected(true));
        choiceButtonB.onClick.AddListener(() => OnChoiceSelected(false));
    }

    /// <summary>
    /// Types out a line letter by letter.
    /// </summary>
    private IEnumerator TypeLine(string line)
    {
        isTyping = true;
        dialogueText.text = ""; // Clear text before typing
        foreach (char c in line.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }

    /// <summary>
    /// Handles what happens after the player selects a choice.
    /// </summary>
    private void OnChoiceSelected(bool pickedA)
    {
        choicePanel.SetActive(false);

        bool correct = (pickedA && currentLine.isChoiceACorrect) || (!pickedA && !currentLine.isChoiceACorrect);

        currentLineIndex++;
        // Advance to next line after a short delay if needed
        // Or wait for another mouse click before calling DisplayNextLine again

        // Automatically continue to the next line or end
        StartCoroutine(WaitAndAdvanceDialogue(correct));
    }
    private IEnumerator WaitAndAdvanceDialogue(bool correct)
    {
        end = true;
        if (correct)
        {
            good.Play();
            dialogueText.text = "BRAVO!";
            ProgressManager.Instance?.MarkCurrentAsSolved();
        }
        else
        {
            bad.Play();
            StaticVariableManager.currentAnimation = Random.Range(4,6);
            dialogueText.text = "❓ Hmm... Peut-être y penser différemment.";
            // TODO: Optionally allow retry logic or just proceed
        }

        yield return new WaitForSeconds(1.5f);
        DisplayNextLine();
    }


    /// <summary>
    /// Advances the dialogue manually (e.g., after typing is done or user clicks).
    /// </summary>
    public void AdvanceDialogue()
    {
        if (!end)
        {
            if (isTyping)
            {
                // If typing is in progress, skip to full line instantly
                StopAllCoroutines();
                dialogueText.text = currentLine.isThought ? $"(Pensée) {currentLine.text}" : currentLine.text;
                isTyping = false;
            }
            else
            {
                currentLineIndex++;
                DisplayNextLine();
            }
        }
    }

    /// <summary>
    /// Ends the dialogue session.
    /// </summary>
    private void EndDialogue()
    {
        FindObjectOfType<InteractionManager>()?.OnDialogueComplete();
       // Optionally trigger something in game flow
    }
}

