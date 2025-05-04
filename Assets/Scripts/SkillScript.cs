using UnityEngine;
using UnityEngine.UI;

public class SkillScript : MonoBehaviour
{
    public Text labelText;
    public Text scoreText;

    void Start()
    {
        UpdateSliderValue();
    }

    void Update()
    {

        // Set label text to this GameObject's name
        if (labelText != null)
        {
            labelText.text = gameObject.name;
        }
        UpdateSliderValue();
    }
    
    void UpdateSliderValue()
    {
        if (scoreText != null && StaticVariableManager.skillValues.ContainsKey(gameObject.name))
        {
            scoreText.text = StaticVariableManager.skillValues[gameObject.name].value.ToString() + "/100";
        }
    }
    public void button()
    {
        StaticVariableManager.clickedSkill = gameObject.name;
    }
}
