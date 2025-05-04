using System.Collections.Generic;
using UnityEngine;

public class StaticVariableManager : MonoBehaviour
{
    public static int currentCharacter = 0;
    public static int currentAnimation = 0;
    public static string clickedObject = "";
    public static bool hasWon;
    public static string clickedSkill = "";
    public static Dictionary<string, SkillData> skillValues = new Dictionary<string, SkillData>()
    {
        { "D�marche �valuative", new SkillData(0f) },
        { "�valuation normative", new SkillData(0f) },
        { "�valuation des comp�tences", new SkillData(0f) },
        { "Corrig�", new SkillData(0f) },
        { "T�che simple", new SkillData(0f) },
        { "T�che complexe", new SkillData(0f) },
        { "Outil de jugement", new SkillData(0)},
        { "Interpr�tation crit�ri�e", new SkillData(0f) },
        { "Interpr�tation normative", new SkillData(0) },
        { "Interpr�tation dynamique", new SkillData(0f) },
        { "Valeurs �valuatives instrumentales", new SkillData(0f) },
        { "Valeurs �valuatives fondamentales", new SkillData(0f) },
        { "Reconnaissance des comp�tences", new SkillData(0f) },
        { "Aide � l�apprentissage", new SkillData(0f) },
        { "Normes et modalit�s", new SkillData(0f) },
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
