using UnityEngine;

public class Stats : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.name = StaticVariableManager.clickedSkill;
    }
}
