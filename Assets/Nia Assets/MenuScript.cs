using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
public GameObject menuPanel;
public GameObject button;
    public AudioSource audioSource;
    private void Start()
    {
        menuPanel.SetActive(false);
        button.SetActive(false);
    }
    public void StartGame()
    {
        audioSource.Play();
        Debug.Log("vghifdl");
        // Replace "GameScene" with the actual name of your gameplay scene
        SceneManager.LoadScene(1);
    }
private IEnumerator Wait(){
    yield return new WaitForSeconds(1f);
    button.SetActive(true);
}
    public void OpenCredits()
    {
        Debug.Log("Options clicked! Add options menu logic here.");
        audioSource.Play();
        menuPanel.SetActive(true);
        StartCoroutine(Wait());
        
    }
    public void CloseCredits()
    {
        Debug.Log("Options clicked! Add options menu logic here.");
       
        menuPanel.SetActive(false);
        button.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
