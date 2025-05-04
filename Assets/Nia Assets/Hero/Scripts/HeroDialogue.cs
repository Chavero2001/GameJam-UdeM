using System.Collections;
using TMPro;
using UnityEngine;

public class HeroDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] currentProblem;
    public float typingSpeed = 0.02f;

    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == currentProblem[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = currentProblem[index];
            }
        }

    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char letter in currentProblem[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void NextLine()
    {
        if (index < currentProblem.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);

        }
    }
}
