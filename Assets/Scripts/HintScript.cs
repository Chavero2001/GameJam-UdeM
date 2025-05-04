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
        if (subject.name == "D�marche �valuative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis compos�e de cinq �tapes, de la planification � la communication."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. On me suit pour �viter de juger � au feeling �."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je commence par � quoi �valuer ? � et je termine par � comment communiquer ? �."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Mon but est de rendre le jugement professionnel rigoureux et structur�."
                : "4. ???";
        }
        else if (subject.name == "�valuation normative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je compare les �l�ves entre eux, souvent avec une courbe normale ou une moyenne."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je cherche � classer, trier ou s�lectionner."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis souvent associ�e � des examens standardis�s."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis l�oppos� d�une �valuation ax�e sur les crit�res ou les progr�s individuels."
                : "4. ???";
        }
        else if (subject.name == "�valuation des comp�tences")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je vise � v�rifier la mobilisation d�un ensemble de ressources dans une situation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je ne cherche pas juste � savoir si tu sais, mais comment tu utilises ce que tu sais."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je m�int�resse autant au processus qu�au produit."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis en lien avec le programme par comp�tence et les contextes authentiques."
                : "4. ???";
        }
        else if (subject.name == "Corrig�")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis le mod�le de r�ponse fourni � l�enseignant pour juger le travail des �l�ves."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. J�indique souvent les bonnes r�ponses ou les �tapes attendues."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis utile surtout pour les t�ches simples, avec une seule solution possible."
                : "3. ???";
        }
        else if (subject.name == "T�che simple")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je cible une ressource pr�cise ou une habilet� unique."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis souvent ferm�e, avec une seule bonne r�ponse."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je ne permets pas vraiment d�analyser des strat�gies ou des raisonnements complexes."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis id�ale pour v�rifier une connaissance isol�e ou une routine."
                : "4. ???";
        }
        else if (subject.name == "T�che complexe")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. J�exige de combiner plusieurs ressources pour r�soudre une situation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je refl�te davantage ce qui pourrait arriver dans la vraie vie."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Il n�y a pas une seule bonne r�ponse, mais plusieurs fa�ons pertinentes de r�ussir."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilis�e pour �valuer des comp�tences."
                : "4. ???";
        }
        else if (subject.name == "Outil de jugement")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. J�inclus souvent des crit�res, des descripteurs et une �chelle."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis essentiel pour soutenir le jugement professionnel."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux prendre la forme d�une grille ou d�un bar�me."
                : "3. ???";
        }
        else if (subject.name == "Interpr�tation crit�ri�e")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je compare le travail � des crit�res �tablis au pr�alable."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je suis fr�quente dans l�approche par comp�tence."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je permets � tous les �l�ves de viser la m�me cible, sans se comparer entre eux."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je favorise l��quit� en rendant les attentes explicites."
                : "4. ???";
        }
        else if (subject.name == "Interpr�tation normative")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m�appuie sur une norme ou un groupe de r�f�rence."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je dis si l��l�ve est � dans la moyenne �, � en dessous � ou � au-dessus �."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux produire des �carts-types et des percentiles."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilis�e dans des contextes s�lectifs ou comp�titifs."
                : "4. ???";
        }
        else if (subject.name == "Interpr�tation dynamique")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m�int�resse � la progression d�un m�me �l�ve dans le temps."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je compare les r�sultats d�une m�me personne � elle-m�me."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je soutiens la r�troaction individualis�e."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent utilis�e dans une perspective d�aide � l�apprentissage."
                : "4. ???";
        }
        else if (subject.name == "Valeurs �valuatives instrumentales")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis orient�e vers l'application pratique et la prise de d�cisions bas�es sur des donn�es collect�es lors de l��valuation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je permets de suivre l��volution des �l�ves et d�adapter l�enseignement en fonction des r�sultats."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je cherche � garantir que l��valuation soit men�e avec exactitude et en utilisant des crit�res clairs."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis ce qui permet d'assurer que l��valuation aide � la prise de d�cisions concernant l'orientation des apprentissages et des pratiques p�dagogiques."
                : "4. ???";
        }
        else if (subject.name == "Valeurs �valuatives fondamentales")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je m�assure que tous les individus, quel que soit leur profil, peuvent d�montrer leur apprentissage dans un cadre �quitable."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Les principes que je repr�sente orientent les pratiques des enseignants et des administrateurs en mati�re d��valuation."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis au c�ur de la r�glementation qui fa�onne les pratiques d��valuation dans les syst�mes �ducatifs."
                : "3. ???";
        }
        else if (subject.name == "Reconnaissance des comp�tences")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je valide formellement ce que l��l�ve sait faire dans un contexte donn�."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je ne me limite pas � une note : je certifie un acquis."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je peux �tre formelle (bulletin, dipl�me)."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis souvent un objectif de l��valuation certificative."
                : "4. ???";
        }
        else if (subject.name == "Aide � l�apprentissage")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis une vis�e centrale de l��valuation formative."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je soutiens l��l�ve dans sa progression par des r�troactions utiles."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je m�inscris dans une logique d�accompagnement."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je suis incompatible avec une �valuation punitive ou strictement sommative."
                : "4. ???";
        }
        else if (subject.name == "Normes et modalit�s")
        {
            hint1.text = StaticVariableManager.skillValues[subject.name].flags[0]
                ? "1. Je suis le cadre d�fini par l��cole ou le minist�re pour encadrer l��valuation."
                : "1. ???";
            hint2.text = StaticVariableManager.skillValues[subject.name].flags[1]
                ? "2. Je pr�cise les moments, les formats, les pond�rations des �valuations."
                : "2. ???";
            hint3.text = StaticVariableManager.skillValues[subject.name].flags[2]
                ? "3. Je suis �crite dans les documents comme le r�gime p�dagogique ou les plans d�intervention."
                : "3. ???";
            hint4.text = StaticVariableManager.skillValues[subject.name].flags[3]
                ? "4. Je garantis l�uniformit�, mais aussi ..."
                : "4. ???";
        }




    }
}
