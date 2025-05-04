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
        { "Démarche évaluative", new SkillData(0f) },
        { "Évaluation normative", new SkillData(0f) },
        { "Évaluation des compétences", new SkillData(0f) },
        { "Corrigé", new SkillData(0f) },
        { "Tâche simple", new SkillData(0f) },
        { "Tâche complexe", new SkillData(0f) },
        { "Outil de jugement", new SkillData(0)},
        { "Interprétation critériée", new SkillData(0f) },
        { "Interprétation normative", new SkillData(0) },
        { "Interprétation dynamique", new SkillData(0f) },
        { "Valeurs évaluatives instrumentales", new SkillData(0f) },
        { "Valeurs évaluatives fondamentales", new SkillData(0f) },
        { "Reconnaissance des compétences", new SkillData(0f) },
        { "Aide à l’apprentissage", new SkillData(0f) },
        { "Normes et modalités", new SkillData(0f) },
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
