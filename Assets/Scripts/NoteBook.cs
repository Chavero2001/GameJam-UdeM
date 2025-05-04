using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NoteBook : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Skills;
    public AudioManager audioManager;
    public Image notebookImage;
    public Color hoverColor = Color.gray; // Customize the hover color
    private Color originalColor;

    private void Start()
    {
        if (notebookImage != null)
        {
            originalColor = notebookImage.color;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Skills != null)
        {
            audioManager.PlaySFX(audioManager.book);
            Skills.SetActive(!Skills.activeSelf);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (notebookImage != null)
        {
            notebookImage.color = hoverColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (notebookImage != null)
        {
            notebookImage.color = originalColor;
        }
    }
}
