using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TransitionController : MonoBehaviour
{
    public CanvasGroup fadeOverlay;
    public float fadeDuration = 1f;
    public GameObject dialogue;

    private void Start()
    {
        dialogue.SetActive(false);
        fadeOverlay.alpha = 0f;
    }

    public IEnumerator FadeOut()
    {
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            fadeOverlay.alpha = Mathf.Lerp(0f, 1f, timer / fadeDuration);
            timer += Time.deltaTime;
            yield return null;
        }
        fadeOverlay.alpha = 1f;
    }

    public IEnumerator FadeIn()
    {
        dialogue.SetActive(true);
        StaticVariableManager.currentAnimation = 0;
        StaticVariableManager.currentCharacter = Random.Range(1, 6);
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            fadeOverlay.alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            timer += Time.deltaTime;
            yield return null;
        }
        fadeOverlay.alpha = 0f;
    }
}
