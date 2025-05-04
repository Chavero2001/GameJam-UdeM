using System.Collections;
using TMPro;
using UnityEngine;

public class HeroDialogueUI : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] currentProblem;
    private int index = 0;
    public float typingSpeed = 0.02f;
    private HeroController heroController;
    public ProblemGenerator problemGenerator;

    void Start()
    {
        dialogueText.text = string.Empty;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
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

    public void StartDialogue(HeroController hero)
    {
        heroController = hero;
        currentProblem = problemGenerator.GetRandomProblem();
        index = 0;
        StopAllCoroutines(); // Detener cualquier animación previa
        dialogueText.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        dialogueText.text = string.Empty; // Asegurar que se borra el texto antes de empezar a escribir
        foreach (char letter in currentProblem[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextLine()
    {
        dialogueText.text = string.Empty;
        if (index < currentProblem.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            heroController.MoveToExit();
        }
    }
}
