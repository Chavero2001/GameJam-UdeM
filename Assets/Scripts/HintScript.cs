using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    public Text hint1;
    public Text hint2;
    public Text hint3;
    public Text hint4;
    public GameObject subject;
    void Update()
    {
        hint4.text = "";
        if (subject.name == "Démarche évaluative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis composée de cinq étapes, de la planification à la communication."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. On me suit pour éviter de juger « au feeling »."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je commence par « quoi évaluer ? » et je termine par « comment communiquer ? »."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Mon but est de rendre le jugement professionnel rigoureux et structuré."
                : "4. ???";
        }
        else if (subject.name == "Évaluation normative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je compare les élèves entre eux, souvent avec une courbe normale ou une moyenne."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je cherche à classer, trier ou sélectionner."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis souvent associée à des examens standardisés."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis l’opposé d’une évaluation axée sur les critères ou les progrès individuels."
                : "4. ???";
        }
        else if (subject.name == "Évaluation des compétences")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je vise à vérifier la mobilisation d’un ensemble de ressources dans une situation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je ne cherche pas juste à savoir si tu sais, mais comment tu utilises ce que tu sais."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je m’intéresse autant au processus qu’au produit."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis en lien avec le programme par compétence et les contextes authentiques."
                : "4. ???";
        }
        else if (subject.name == "Corrigé")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis le modèle de réponse fourni à l’enseignant pour juger le travail des élèves."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. J’indique souvent les bonnes réponses ou les étapes attendues."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis utile surtout pour les tâches simples, avec une seule solution possible."
                : "3. ???";
        }
        else if (subject.name == "Tâche simple")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je cible une ressource précise ou une habileté unique."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis souvent fermée, avec une seule bonne réponse."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je ne permets pas vraiment d’analyser des stratégies ou des raisonnements complexes."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis idéale pour vérifier une connaissance isolée ou une routine."
                : "4. ???";
        }
        else if (subject.name == "Tâche complexe")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. J’exige de combiner plusieurs ressources pour résoudre une situation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je reflète davantage ce qui pourrait arriver dans la vraie vie."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Il n’y a pas une seule bonne réponse, mais plusieurs façons pertinentes de réussir."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilisée pour évaluer des compétences."
                : "4. ???";
        }
        else if (subject.name == "Outil de jugement")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. J’inclus souvent des critères, des descripteurs et une échelle."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis essentiel pour soutenir le jugement professionnel."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux prendre la forme d’une grille ou d’un barème."
                : "3. ???";
        }
        else if (subject.name == "Interprétation critériée")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je compare le travail à des critères établis au préalable."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis fréquente dans l’approche par compétence."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je permets à tous les élèves de viser la même cible, sans se comparer entre eux."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je favorise l’équité en rendant les attentes explicites."
                : "4. ???";
        }
        else if (subject.name == "Interprétation normative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m’appuie sur une norme ou un groupe de référence."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je dis si l’élève est « dans la moyenne », « en dessous » ou « au-dessus »."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux produire des écarts-types et des percentiles."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilisée dans des contextes sélectifs ou compétitifs."
                : "4. ???";
        }
        else if (subject.name == "Interprétation dynamique")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m’intéresse à la progression d’un même élève dans le temps."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je compare les résultats d’une même personne à elle-même."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je soutiens la rétroaction individualisée."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilisée dans une perspective d’aide à l’apprentissage."
                : "4. ???";
        }
        else if (subject.name == "Valeurs évaluatives instrumentales")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis orientée vers l'application pratique et la prise de décisions basées sur des données collectées lors de l’évaluation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je permets de suivre l’évolution des élèves et d’adapter l’enseignement en fonction des résultats."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je cherche à garantir que l’évaluation soit menée avec exactitude et en utilisant des critères clairs."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis ce qui permet d'assurer que l’évaluation aide à la prise de décisions concernant l'orientation des apprentissages et des pratiques pédagogiques."
                : "4. ???";
        }
        else if (subject.name == "Valeurs évaluatives fondamentales")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m’assure que tous les individus, quel que soit leur profil, peuvent démontrer leur apprentissage dans un cadre équitable."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Les principes que je représente orientent les pratiques des enseignants et des administrateurs en matière d’évaluation."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis au cœur de la réglementation qui façonne les pratiques d’évaluation dans les systèmes éducatifs."
                : "3. ???";
        }
        else if (subject.name == "Reconnaissance des compétences")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je valide formellement ce que l’élève sait faire dans un contexte donné."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je ne me limite pas à une note : je certifie un acquis."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux être formelle (bulletin, diplôme)."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent un objectif de l’évaluation certificative."
                : "4. ???";
        }
        else if (subject.name == "Aide à l’apprentissage")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis une visée centrale de l’évaluation formative."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je soutiens l’élève dans sa progression par des rétroactions utiles."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je m’inscris dans une logique d’accompagnement."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis incompatible avec une évaluation punitive ou strictement sommative."
                : "4. ???";
        }
        else if (subject.name == "Normes et modalités")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis le cadre défini par l’école ou le ministère pour encadrer l’évaluation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je précise les moments, les formats, les pondérations des évaluations."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis écrite dans les documents comme le régime pédagogique ou les plans d’intervention."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je garantis l’uniformité, mais aussi ..."
                : "4. ???";
        }




    }
}
