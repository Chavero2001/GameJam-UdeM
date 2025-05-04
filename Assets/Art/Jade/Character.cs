using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject[] characters; // Assign all 5 characters in the Inspector

    private int currentCharacterIndex = 0;
    private int currentAnimation = 0;

    void Update()
    {
        // Only switch character if it changed
        if (StaticVariableManager.currentCharacter != currentCharacterIndex)
        {
            SwitchCharacter(StaticVariableManager.currentCharacter);
        }

        // Only update animation if it changed
        if (StaticVariableManager.currentAnimation != currentAnimation)
        {
            UpdateAnimation(StaticVariableManager.currentAnimation);
        }
    }

    void SwitchCharacter(int characterIndex)
    {
        currentCharacterIndex = characterIndex;

        // Deactivate all
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(i == characterIndex - 1);
        }
    }

    void UpdateAnimation(int animationName)
    {
        currentAnimation = animationName;

        if (currentCharacterIndex >= 1 && currentCharacterIndex <= characters.Length)
        {
            Animator animator = characters[currentCharacterIndex - 1].GetComponent<Animator>();
            if (animator)
            {
                animator.SetInteger("State", currentAnimation);
            }
        }
    }
}
